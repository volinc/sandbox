using System.Threading.Tasks;

namespace SignalR.Client
{
    public class ConnectivityService
    {
        public Task<bool> IsServerReachableAsync() => Task.FromResult(true);
    }
}
