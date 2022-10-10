using Broadcaster.Hubs.HubModels;
using Broadcaster.Hubs;
using Broadcaster.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Broadcaster.Repository;
using Broadcaster.Services;

namespace Broadcaster.Controllers
{
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly IHubContext<DatabaseHub, ITableClient> _hubContext;
        private readonly IChatterDatabaseService _chatterDatabaseService;

        public TableController(
            IHubContext<DatabaseHub, ITableClient> hubContext,
            IChatterDatabaseService chatterDatabaseService)
        {
            _hubContext = hubContext;
            _chatterDatabaseService = chatterDatabaseService;
        }

        [Route("api/notify-all")]
        [HttpPost]
        public async Task<IActionResult> NotifyTableChange(TableNotify notify)
        {
            await _hubContext.Clients.All.TableChanged(notify);
            return Ok("Notified all clients");
        }

        [Route("api/add-user")]
        public async Task<IActionResult> AddUser()
        {

            return Ok();
        }
    }
}