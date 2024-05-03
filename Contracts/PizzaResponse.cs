namespace PizzaOrderApp.Contracts
{
    public record PizzaResponse(
        Guid Id,
        string Name,
        string Description,
        decimal Price);
}
