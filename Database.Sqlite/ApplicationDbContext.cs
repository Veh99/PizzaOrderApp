using Microsoft.EntityFrameworkCore;
using PizzaOrderApp.Configurations;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Database.Sqlite
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {
        }

        public DbSet<OrderEntity> Orders { get; set; }
        public DbSet<PizzaEntity> Pizzas { get; set; }
        public DbSet<UserEntity> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderConfigutarion());
            modelBuilder.ApplyConfiguration(new PizzaConfigutarion());
            modelBuilder.ApplyConfiguration(new UserConfigutarion());

            base.OnModelCreating(modelBuilder);
        }
        

    }
}
