namespace PizzaOrderApp.Contracts
{
    public record UserLoginRequest(
        string UserName,
        string Password);
}