using Microsoft.AspNetCore.SignalR;

namespace Broadcaster.Hubs
{
    public class DatabaseHub : Hub 
    {
        public Task NotifyTableUpdate()
        {
            return Clients.All.SendAsync("");
        }
    }
}