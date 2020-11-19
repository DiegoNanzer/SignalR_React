
using System.Threading.Tasks;

namespace SignalR.Hubs
{
    public interface IStatusApiHub
    {
        Task ReceiveStatusApi(int idProcess);
    }
}