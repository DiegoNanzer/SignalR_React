using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using SignalR.Hubs;

namespace SignalR.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckProcessController : ControllerBase
    {
        private static DateTime _lastProcess;
        private static int _idProcess = 0;
        private readonly IHubContext<StatusApiHub, IStatusApiHub> _statusHub;

        public HealthCheckProcessController(IHubContext<StatusApiHub, IStatusApiHub> statusHub)
        {
            _statusHub = statusHub;
        }

        [HttpPost]
        public async Task<ActionResult> Post()
        {
            if (_lastProcess.AddSeconds(10) < DateTime.Now)
            {
                StatusApiHub hub = new StatusApiHub();
                _idProcess++;
                await _statusHub.Clients.All.ReceiveStatusApi(_idProcess);
                _lastProcess = DateTime.Now;
            }

            return Ok();
        }
    }
}
