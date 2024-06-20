using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp.Contracts;
using PizzaOrderApp.Repositories;

namespace PizzaOrderApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userContext;

        public UserController(UserRepository userContext)
        {
            _userContext = userContext;
            
        }
        [HttpGet]
        public async Task<ActionResult<List<UserResponse>>> GetUsers() 
        {
            var users = await _userContext.Get();
            var response = users.Select(u => new UserResponse(u.Id, u.UserName, u.Address, u.PhoneNumber, u.Password));
            return Ok(response);

        }
        [HttpGet("{id}")]
        public async Task<ActionResult<UserResponse>> GetUserById(Guid id)
        {
            var user = await _userContext.GetById(id);
            return Ok(user);
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

        [HttpPut("{id}")]
        public async Task UpdateUser(Guid id, [FromBody] UserRequest request)
        {
            await _userContext.Update(id, request.UserName, request.Password, request.Address, request.PhoneNumber);
        }

        [HttpDelete]
        public async Task DeleteUser(Guid id)
        {
            await _userContext.Delete(id);
        }
    }
}       
