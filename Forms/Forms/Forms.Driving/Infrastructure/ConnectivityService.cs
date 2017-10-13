using System;
using System.Threading.Tasks;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;

namespace Forms.Driving.Infrastructure
{
    public class ConnectivityService : IDisposable, IConnectivityService
    {
        private readonly ServiceClientConfiguration configuration;
        public event EventHandler<bool> ConnectivityChanged;
        
        public ConnectivityService(ServiceClientConfiguration configuration)
        {
            this.configuration = configuration;
            CrossConnectivity.Current.ConnectivityChanged += Current_ConnectivityChanged;
            CrossConnectivity.Current.ConnectivityTypeChanged += Current_ConnectivityTypeChanged;
        }

        private async void Current_ConnectivityTypeChanged(object sender, ConnectivityTypeChangedEventArgs e)
        {
            if (await CrossConnectivity.Current.IsRemoteReachable(configuration.ApiAuthority))
                ConnectivityChanged?.Invoke(this, e.IsConnected);
        }

        private void Current_ConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {            
            ConnectivityChanged?.Invoke(this, e.IsConnected);
        }

        public bool IsConnected => CrossConnectivity.Current.IsConnected;

        public async Task<bool> IsServerReachableAsync() =>
#if DEBUG
        await Task.FromResult(true);
#else
        await CrossConnectivity.Current.IsRemoteReachable(configuration.ApiAuthority);
#endif

        public void Dispose()
        {            
            CrossConnectivity.Current.ConnectivityChanged -= Current_ConnectivityChanged;
            CrossConnectivity.Current.ConnectivityTypeChanged -= Current_ConnectivityTypeChanged;
        }        
    }    
}