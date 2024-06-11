using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using PizzaOrderApp.Models;
using PizzaOrderApp.Repositories;
using System.Globalization;

namespace PizzaOrderApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController
    {
        private readonly OrdersRepository _ordersContext;

        public OrderController(OrdersRepository ordersContext)
        {
            _ordersContext = ordersContext;
        }

        [HttpGet]
        public async Task<ActionResult<List<OrderEntity>>> GetOrders()
        {
            return await _ordersContext.Get();
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<OrderEntity?>> GetOrderById(Guid id)
        {
            var order = await _ordersContext.GetById(id);

            return order;
        }

        [HttpPost]
        public async Task CreateOrder(Guid id, Guid userId, string status, params Guid[] pizza)
        {
            await _ordersContext.Add(id, userId, status, pizza);
            
        }

        [HttpPut("{id:guid}")]
        public async Task<Guid> UpdateOrder(Guid id, [FromBody] OrderEntity order)
        {
            var orderId = await _ordersContext.Update(id, order.Status);

            return orderId;
           
        }

        [HttpDelete]
        public async Task DeleteOrder(Guid id)
        {
            await _ordersContext.Delete(id);
        }
    }
}
