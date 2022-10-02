using Broadcaster.Hubs;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;

namespace Broadcaster.Controllers
{
    [ApiController]
    public class TableController : ControllerBase
    {
        private readonly IHubContext<DatabaseHub> _hubContext;

        public TableController(IHubContext<DatabaseHub> hubContext)
        {
            _hubContext = hubContext;
        }

        [Route("api/notify-all")]
        [HttpPost]
        public async Task<IActionResult> NotifyTableChnage(string tableName)
        {
            await _hubContext.Clients.All.SendAsync("TableChanged", tableName);

            return Ok("Notified all clients");
        }
    }
}