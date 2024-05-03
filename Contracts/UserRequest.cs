namespace PizzaOrderApp.Contracts
{
    public record UserRequest(
        string UserName,
        string Address,
        string PhoneNumber,
        string Password);
}
