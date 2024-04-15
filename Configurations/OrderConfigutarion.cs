using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Configurations
{
    public class OrderConfigutarion : IEntityTypeConfiguration<OrderEntity>
    {
        public void Configure(EntityTypeBuilder<OrderEntity> builder)
        {
            builder.HasKey(o => o.Id);

            builder.HasOne(o => o.User)
                .WithMany(u => u.Orders)
                .HasForeignKey(o => o.UserId);
                

            builder.HasMany(o => o.Pizzas)
                .WithOne(p => p.Order)
                .HasForeignKey(p => p.OrderId);

        }
    }
}
