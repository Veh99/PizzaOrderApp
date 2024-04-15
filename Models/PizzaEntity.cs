namespace PizzaOrderApp.Models
{
    public class PizzaEntity
    {
        public Guid Id { get; set; } 
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Photo { get; set; }
        public Guid OrderId { get; set; }
        public OrderEntity Order { get; set; }

        public PizzaEntity(Guid id, string name, string description, decimal price, byte[] photo)
        {
            Id = id;
            Name = name;
            Description = description;
            Price = price;
            Photo = photo;
        }
    }
}
