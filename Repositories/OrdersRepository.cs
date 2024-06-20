using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using PizzaOrderApp.Contracts;
using PizzaOrderApp.Database.Sqlite;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Repositories
{
    public class OrdersRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public OrdersRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
            
        }   

        public async Task<List<OrderEntity>> Get()
        {
            var orders = await _dbContext.Orders
                .AsNoTracking()
                .Include(o => o.Pizzas)
                .ToListAsync();

            return orders;
        }

        public async Task<OrderEntity?> GetById(Guid id)
        {
            return await _dbContext.Orders
                .AsNoTracking()
                .Include (o => o.Pizzas)
                .FirstOrDefaultAsync(o => o.Id == id);
        }
            
        public async Task Add(Guid id, Guid userId, string status, params Guid[] pizza)
        {
            var orderEntity = new OrderEntity
            {
                Id = id,
                UserId = userId,
                Status = status
            };

            await _dbContext.AddAsync(orderEntity);
            var piz = _dbContext.Pizzas.Where(x => pizza.Contains(x.Id));
            piz.ToList().ForEach(x => orderEntity.Pizzas.Add(x));
            await _dbContext.SaveChangesAsync();
        }

        public async Task<Guid> Update(Guid id, string status)
        {
            await _dbContext.Orders
                .Where(o => o.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(o => o.Status, status));

            return id;
        }

        public async Task Delete(Guid id)
        {
            await _dbContext.Orders
                .Where(o => o.Id == id)
                .ExecuteDeleteAsync();
            
        }
    }
}
