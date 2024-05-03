using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzaOrderApp.Models;

namespace PizzaOrderApp.Configurations
{
    public class PizzaConfigutarion : IEntityTypeConfiguration<PizzaEntity>
    {
        public void Configure(EntityTypeBuilder<PizzaEntity> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(p => p.Order)
                .WithMany(o => o.Pizzas)
                /*.HasForeignKey(p => p.OrderId)*/;

        }
    }
}
