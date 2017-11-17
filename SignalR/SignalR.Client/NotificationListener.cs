using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Transports;

namespace SignalR.Client
{
    public class NotificationListener : IDisposable
    {
        private const string HubName = "NotificationHub";

        public event EventHandler<Offer> NewOffer;

        private bool _disposed;
        
        private readonly ConnectivityService _connectivityService;

        private readonly HubConnection _hubConnection;
        private readonly OAuthHttpClient _authHttpClient;
        private readonly IHubProxy _hubProxy;        

        private IReadOnlyList<IDisposable> _localMethods;

        public NotificationListener(ApiConfig apiConfig, OAuthMessageHandlerFactory authMessageHandlerFactory,
            ConnectivityService connectivityService)
        {            
            _connectivityService = connectivityService;

            _hubConnection = new HubConnection(apiConfig.Url);
            _hubConnection.Closed += HubConnectionOnClosed;
            _hubConnection.StateChanged += HubConnectionOnStateChanged;
            _hubConnection.Received += HubConnectionOnReceived;
            _hubConnection.TraceLevel = TraceLevels.All;
            _hubConnection.TraceWriter = Console.Out;

            _authHttpClient = new OAuthHttpClient(authMessageHandlerFactory);
            
            _hubProxy = _hubConnection.CreateHubProxy(HubName);

            SubscribeHubProxy();

            EstablishConnectionAsync().Forget();
        }        

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;

            if (disposing)
            {
                UnsubscribeHubProxy();
                
                _hubConnection.Closed -= HubConnectionOnClosed;
                _hubConnection.StateChanged -= HubConnectionOnStateChanged;
                _hubConnection.Received -= HubConnectionOnReceived;
                _hubConnection.Stop(TimeSpan.Zero);
                _hubConnection.Dispose();

                _disposed = true;
            }
        }        

        private async void HubConnectionOnClosed()
        {
            await Delay();
            await EstablishConnectionAsync();
        }

        private static void HubConnectionOnStateChanged(StateChange stateChange)
        {
            Console.WriteLine($"{stateChange.OldState} -> {stateChange.NewState}");
        }

        private static void HubConnectionOnReceived(string s)
        {
            Console.WriteLine(s);
        }

        private async Task EstablishConnectionAsync()
        {            
            try
            {
                while (!await _connectivityService.IsServerReachableAsync())
                    await Delay();

                if (_hubConnection.State != ConnectionState.Disconnected)
                    return;

                var clientTransport = new AutoTransport(_authHttpClient);
                await _hubConnection.Start(clientTransport);
            }
            catch (Exception exception)
            {                
                Console.Error.WriteLine(exception.Message);                
            }                                        
        }
        
        private void SubscribeHubProxy()
        {
            if (_hubProxy == null)
            {                
                _localMethods = new []
                {
                    _hubProxy.On<Offer>(nameof(NewOffer), data => NewOffer?.Invoke(this, data)),
                };                
            }
        }

        private void UnsubscribeHubProxy()
        {
            if (_hubProxy != null)
            {
                foreach (var localMethod in _localMethods)
                    localMethod.Dispose();

                _localMethods = null;                
            }
        }

        private static Task Delay(TimeSpan? delay = null) => Task.Delay(delay ?? TimeSpan.FromSeconds(2));              
    }    
}
