using Microsoft.EntityFrameworkCore;
using PizzaOrderApp.Database.Sqlite;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Repositories
{
    public class UserRepository
    {
        public readonly ApplicationDbContext _dbContext;

        public UserRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task Add(Guid id, string userName, string address, string phoneNumber, string password)
        {
            var userEntity = new UserEntity
            {
                Id = id,
                UserName = userName,
                Password = password,
                Address = address,
                PhoneNumber = phoneNumber
            };

            await _dbContext.AddAsync(userEntity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task Delete(Guid id)
        {
            await _dbContext.Users
                .Where(u => u.Id == id)
                .ExecuteDeleteAsync();
        }

        public async Task<List<UserEntity>> Get()
        {
            var userEntities = await _dbContext.Users
                .AsNoTracking()
                .ToListAsync();

            return userEntities;
        }

        public async Task<UserEntity?> GetById(Guid id)
        {
            return await _dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task<UserEntity?> GetByUsername(string userName)
        {
            return await _dbContext.Users
                .AsNoTracking()
                .FirstOrDefaultAsync(u => u.UserName == userName);
        }

        public async Task Update(Guid id, string userName, string password, string address, string phoneNumber)
        {
            await _dbContext.Users
           .Where(u => u.Id == id)
           .ExecuteUpdateAsync(s => s
           .SetProperty(u => u.Address, address)
           .SetProperty(u => u.PhoneNumber, phoneNumber)
           .SetProperty(u => u.UserName, userName)
           .SetProperty(u => u.Password, password));
        }
    }
}