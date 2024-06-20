using PizzaOrderApp.Models;

namespace PizzaOrderApp.Contracts
{
    public record OrderRequest(
        string Status,
        Guid UserId,
        ICollection<PizzaEntity> Pizzas);
}
