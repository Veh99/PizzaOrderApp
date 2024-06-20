using Microsoft.AspNetCore.Server.HttpSys;

namespace PizzaOrderApp.Models
{
    public class PizzaEntity
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        //public OrderEntity Order { get; set; }

    }
}
