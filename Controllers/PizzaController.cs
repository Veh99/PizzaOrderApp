using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp.Contracts;
using PizzaOrderApp.Models;
using PizzaOrderApp.Repositories;

namespace PizzaOrderApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PizzaController : ControllerBase
    {
        private readonly PizzaRepository _pizzaContext;

        public PizzaController(PizzaRepository pizzaContext)
        {
            _pizzaContext = pizzaContext;
        }

        [HttpGet]   
        public async Task<ActionResult<List<PizzaResponse>>> GetPizzas()
        {
            var pizzas = await _pizzaContext.Get();

            return Ok(pizzas);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaResponse>> GetPizzaById(Guid id)
        {
            var pizza = await _pizzaContext.GetById(id);
            return Ok(pizza);
        }

        [HttpPost]
        public async Task CreatePizza(Guid id, string name, string description, decimal price)
        {
            await _pizzaContext.Create(id, name, description, price);
        }

        [HttpPut("{id}")]
        public async Task UpdatePizza(Guid id, [FromBody] PizzaRequest pizza)
        {
            await _pizzaContext.Update(id, pizza.Name, pizza.Description, pizza.Price);
        }

        [HttpDelete("{id}")]
        public async Task DeletePizza(Guid id)
        {
            await _pizzaContext.Delete(id);
        }
    }
}
