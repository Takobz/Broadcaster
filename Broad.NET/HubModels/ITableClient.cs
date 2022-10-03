using Broadcaster.Models;
using System.Threading;

namespace Broadcaster.HubModels 
{
    public interface ITableClient 
    {
        Task TableChanged(TableNotify notification);
    }
}