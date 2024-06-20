using System.Text.Json.Serialization;

namespace PizzaOrderApp.Models
{
    public class OrderEntity
    {
        public Guid Id { get; set; }
        public string Status { get; set; } = string.Empty;
        public Guid UserId { get; set; }
        public ICollection<PizzaEntity> Pizzas { get; set; } = [];
        [JsonIgnore]
        public UserEntity? User { get; set; }

    }
}
