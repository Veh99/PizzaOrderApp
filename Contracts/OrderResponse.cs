using PizzaOrderApp.Models;
using System.Security.Cryptography.X509Certificates;

namespace PizzaOrderApp.Contracts
{
    public record OrderResponse
    (
        Guid Id,
        string Status,
        Guid UserId,
        ICollection<PizzaEntity> Pizzas);
}
