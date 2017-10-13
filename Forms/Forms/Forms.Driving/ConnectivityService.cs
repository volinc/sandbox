using System;
using System.Threading.Tasks;
using Forms.Driving.Infrastructure;

namespace Forms.Driving
{
    public class ConnectivityService : IConnectivityService
    {
        public ConnectivityService()
        {
            ConnectivityChanged?.Invoke(this, true);
        }

        public event EventHandler<bool> ConnectivityChanged;

        public Task<bool> IsServerReachableAsync() => Task.FromResult(true);

        public bool IsConnected => true;
    }
}
