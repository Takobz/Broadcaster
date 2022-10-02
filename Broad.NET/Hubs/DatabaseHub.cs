using Broadcaster.Models;
using Microsoft.AspNetCore.SignalR;

namespace Broadcaster.Hubs
{
    public class DatabaseHub : Hub 
    {
        public Task NotifyTableUpdate(TableNotify notify)
        {
            return Clients.All.SendAsync("tableChanged", notify.TableName);
        }
    }
}