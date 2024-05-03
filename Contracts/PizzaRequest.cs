namespace PizzaOrderApp.Contracts
{
    public record PizzaRequest(
        string Name,
        string Description,
        decimal Price);
}

