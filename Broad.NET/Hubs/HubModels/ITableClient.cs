using Broadcaster.Models;
using System.Threading;

namespace Broadcaster.Hubs.HubModels 
{
    public interface ITableClient 
    {
        Task TableChanged(TableNotify notification);
    }
}