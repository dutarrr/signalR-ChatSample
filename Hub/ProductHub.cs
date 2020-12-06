using Microsoft.AspNetCore.SignalR;
using SignalRChat.Models;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ProductHub : Hub
    {
        public override Task OnConnectedAsync()
        {
            return base.OnConnectedAsync();
        }
    }
}