using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp.Contracts;
using PizzaOrderApp.Interfaces;
using PizzaOrderApp.Repositories;

namespace PizzaOrderApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IPasswordHasher _passwordHasher;
        private readonly JwtProvider _provider;
        private readonly UserRepository _userContext;

        public UserController(UserRepository userContext, IPasswordHasher passwordHasher, JwtProvider provider)
        {
            _userContext = userContext;
            _passwordHasher = passwordHasher;
            _provider = provider;
        }

        [HttpPost]
        public async Task CreateUser(Guid id, [FromBody] UserRequest request)
        {
            await _userContext.Add(
                Guid.NewGuid(),
                request.UserName,
                request.Address,
                request.PhoneNumber,
                request.Password);
        }

        [HttpDelete]
        public async Task DeleteUser(Guid id)
        {
            await _userContext.Delete(id);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetUserById(Guid id)
        {
            var user = await _userContext.GetById(id);
            return Ok(user);
        }

        [HttpGet]
        public async Task<ActionResult<List<UserResponse>>> GetUsers()
        {
            var users = await _userContext.Get();
            var response = users.Select(u => new UserResponse(u.Id, u.UserName, u.Address, u.PhoneNumber, u.Password));
            return Ok(response);
        }

        [HttpPost]
        [Produces("text/plain")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [Route("/login")]
        public async Task<ActionResult<string>> Login([FromBody] UserLoginRequest request)
        {
            var user = await _userContext.GetByUsername(request.UserName) ?? throw new Exception("No user with such login");
            bool isPasswordCorrect = _passwordHasher.Verify(request.Password, user.Password);

            if (!isPasswordCorrect)
            {
                throw new Exception("Wrong password");
            }

            string token = _provider.GenerateJwt(request);

            var pathBase = HttpContext;
            pathBase.Response.Cookies.Append("COOKIES", token);

            return Ok(token);
        }

        [HttpPost]
        [Route("/register")]
        public async Task Register([FromBody] UserRequest request)
        {
            var password = BCrypt.Net.BCrypt.EnhancedHashPassword(request.Password);
            await _userContext.Add(
                Guid.NewGuid(),
                request.UserName,
                request.Address,
                request.PhoneNumber,
                password);
        }

        [HttpPut("{id}")]
        public async Task UpdateUser(Guid id, [FromBody] UserRequest request)
        {
            await _userContext.Update(id, request.UserName, request.Password, request.Address, request.PhoneNumber);
        }
    }
}