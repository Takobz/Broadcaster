using Broadcaster.Hubs.HubModels;
using Broadcaster.Models;
using Microsoft.AspNetCore.SignalR;

namespace Broadcaster.Hubs
{
    public class DatabaseHub : Hub<ITableClient> 
    {
        public Task NotifyTableUpdate(TableNotify notify)
        {
            return Clients.All.TableChanged(notify);
        }
    }
}