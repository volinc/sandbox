using System;
using System.Threading.Tasks;

namespace Forms.Driving.Infrastructure
{
    public interface IConnectivityService
    {
        bool IsConnected { get; }

        event EventHandler<bool> ConnectivityChanged;

        Task<bool> IsServerReachableAsync();
    }
}