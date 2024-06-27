using Microsoft.AspNetCore.SignalR;

namespace PizzaOrderApp.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string message, string userName)
        {
            await this.Clients.All.SendAsync("Recieve", message, userName);
        }
    }
}