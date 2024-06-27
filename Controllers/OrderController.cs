using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp.Contracts;
using PizzaOrderApp.Models;
using PizzaOrderApp.Repositories;

namespace PizzaOrderApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {
        private readonly OrdersRepository _ordersContext;

        public OrderController(OrdersRepository ordersContext)
        {
            _ordersContext = ordersContext;
        }

        [HttpPost]
        public async Task CreateOrder(Guid id, Guid userId, string status, params Guid[] pizza)
        {
            await _ordersContext.Add(id, userId, status, pizza);
        }

        [HttpDelete]
        public async Task DeleteOrder(Guid id)
        {
            await _ordersContext.Delete(id);
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<List<OrderResponse>>> GetOrders()
        {
            var orders = await _ordersContext.Get();

            var response = orders.Select(o => new OrderResponse(o.Id, o.Status, o.UserId, o.Pizzas)).ToList();
            return response;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<OrderResponse>> GetUserById(Guid id)
        {
            var order = await _ordersContext.GetById(id);
            return Ok(order);
        }

        [HttpPut("{id}")]
        public async Task<Guid> UpdateOrder(Guid id, [FromBody] OrderRequest order)
        {
            var orderId = await _ordersContext.Update(id, order.Status);

            return orderId;
        }
    }
}