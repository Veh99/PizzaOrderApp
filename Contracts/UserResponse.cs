namespace PizzaOrderApp.Contracts
{
    public record UserResponse(
        Guid id,
        string UserName,
        string Address,
        string PhoneNumber,
        string Password);

}
