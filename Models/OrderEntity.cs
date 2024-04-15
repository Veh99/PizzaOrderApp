namespace PizzaOrderApp.Models
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public List<PizzaEntity> Pizzas { get; set; } = [];
        public Guid UserId { get; set; }
        public UserEntity User { get; set; }
    }
}
