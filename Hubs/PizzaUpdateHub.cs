using Microsoft.AspNetCore.SignalR;

namespace PizzaOrderApp.Hubs
{
    public class PizzaUpdateHub : Hub
    {
        public async Task DatabaseUpdate(string message)
        {
            await Clients.All.SendAsync("Recieve", message);
        }
    }
}