using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public class StatusApiHub : Hub<IStatusApiHub>
    {
        public async Task AlertAll(int idProcess)
        {
            await Clients.All.ReceiveStatusApi(idProcess);
        }
    }
}