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
            var response = pizzas.Select(p => new PizzaResponse(p.Id, p.Name, p.Description, p.Price));
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PizzaResponse>> GetPizzaById(Guid id)
        {
            var pizza = await _pizzaContext.GetById(id);
            return Ok(pizza);
        }

        [HttpPost]
        public async Task CreatePizza(Guid id, [FromBody] PizzaRequest request)
        {
            await _pizzaContext.Create(
                Guid.NewGuid(),
                request.Name,
                request.Description,
                request.Price);
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
