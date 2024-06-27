using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using PizzaOrderApp.Database.Sqlite;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Repositories
{
    public class PizzaRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public PizzaRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Create(Guid id, string name, string description, decimal price)
        {
            var pizza = new PizzaEntity
            {
                Id = id,
                Name = name,
                Description = description,
                Price = price
            };

            await _dbContext.AddAsync(pizza);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            await _dbContext.Pizzas
                .Where(p => p.Id == id)
                .ExecuteDeleteAsync();
        }

        public async Task<List<PizzaEntity>> Get()
        {
            var pizzas = await _dbContext.Pizzas
                .AsNoTracking()
                .ToListAsync();

            return pizzas;
        }

        public async Task<PizzaEntity?> GetById(Guid id)
        {
            return await _dbContext.Pizzas
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task Update(Guid id, string name, string description, decimal price)
        {
            await _dbContext.Pizzas
                .Where(p => p.Id == id)
                .ExecuteUpdateAsync(s => s
                .SetProperty(p => p.Name, name)
                .SetProperty(p => p.Description, description)
                .SetProperty(p => p.Price, price));
        }
    }
}