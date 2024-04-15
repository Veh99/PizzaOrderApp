using Microsoft.EntityFrameworkCore;
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
            return await _dbContext.Orders
                .AsNoTracking()
                .ToListAsync();    
        }

        public async Task<OrderEntity?> GetById(Guid id)
        {
            return await _dbContext.Orders
                .AsNoTracking()
                .FirstOrDefaultAsync(o => o.Id == id);
        }
            
        public async Task Add(Guid id, string status)
        {
            var orderEntity = new OrderEntity
            {
                Id = id,
                Status = status
            };

            await _dbContext.AddAsync(orderEntity);
            await _dbContext.SaveChangesAsync();

        }

        public async Task Update(Guid id, string status)
        {
            await _dbContext.Orders
                .Where(o => o.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(o => o.Status, status));

        }

        public async Task Delete(Guid id)
        {
            await _dbContext.Orders
                .Where(o => o.Id == id)
                .ExecuteDeleteAsync();
            

        }
    }
}
