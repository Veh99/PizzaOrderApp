using Microsoft.AspNetCore.Server.HttpSys;

namespace PizzaOrderApp.Models
{
    public class PizzaEntity
    {
        public Guid Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public decimal Price { get; set; } = 0;
        //public byte[] Photo { get; set; }
        //public Guid OrderId { get; set; }
        public OrderEntity Order { get; set; }

        //public PizzaEntity(Guid id, string name, string description, decimal price, byte[] photo)
        //{
        //    Id = id;
        //    Name = name;
        //    Description = description;
        //    Price = price;
        //    Photo = photo;
        //}
    }
}
