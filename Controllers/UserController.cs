using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using PizzaOrderApp.Models;
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
        public async Task<ActionResult<List<UserEntity>>> GetUsers() 
        {
            var users = await _userContext.Get();

            return Ok(users);

        }
        
    }
}
