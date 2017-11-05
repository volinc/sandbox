using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Http;
using Microsoft.AspNet.SignalR.Client.Transports;

namespace SignalR.Client
{
    public class SignalRClient : IDisposable
    {
        private const string HubName = "NotificationHub";

        private bool disposed;

        private readonly TokenStore tokenStore;
        private readonly ConnectivityService connectivityService;
        private readonly HubConnection hubConnection;

        private IReadOnlyList<IDisposable> localMethods;
        private IHubProxy hubProxy;
        
        public SignalRClient(ApiConfig apiConfig, TokenStore tokenStore, ConnectivityService connectivityService)
        {
            this.tokenStore = tokenStore;
            this.connectivityService = connectivityService;

            hubConnection = new HubConnection(apiConfig.Url);

            hubConnection.Error += HubConnectionOnError;
            hubConnection.Closed += HubConnectionOnClosed;
            hubConnection.StateChanged += HubConnectionOnStateChanged;
            hubConnection.ConnectionSlow += HubConnectionOnConnectionSlow;
            hubConnection.Reconnecting += HubConnectionOnReconnecting;
            hubConnection.Reconnected += HubConnectionOnReconnected;

            hubConnection.TraceLevel = TraceLevels.All;
            hubConnection.TraceWriter = Console.Out;

            SubscribeProxy();
        }

        private void HubConnectionOnReconnecting() => Trace();

        private void HubConnectionOnReconnected() => Trace();

        private void HubConnectionOnError(Exception exception)
        {
            Trace(exception);
        }

        private async void HubConnectionOnClosed()
        {
            await EstablishConnectionAsync();
        }

        private void HubConnectionOnStateChanged(StateChange stateChange)
        {
            Trace(new Dictionary<string, object>
            {
                {nameof(stateChange), $"{stateChange.OldState} -> {stateChange.NewState}"}
            });
        }

        private void HubConnectionOnConnectionSlow()
        {
            Trace();
        }

        public event EventHandler<Offer> NewOffer;

        public bool IsStarted { get; private set; }

        public Task Start()
        {
            if (IsStarted)
                return Task.CompletedTask;

            IsStarted = true;

            return EstablishConnectionAsync();
        }

        public Task Stop()
        {
            if (!IsStarted)
                return Task.CompletedTask;

            IsStarted = false;
            
            return CloseConnectionAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed) return;

            if (disposing)
            {
                UnsubscribeProxy();

                hubConnection.Error -= HubConnectionOnError;
                hubConnection.Closed -= HubConnectionOnClosed;
                hubConnection.StateChanged -= HubConnectionOnStateChanged;
                hubConnection.ConnectionSlow -= HubConnectionOnConnectionSlow;
                hubConnection.Stop();
                hubConnection.Dispose();

                disposed = true;
            }
        }

        private async Task EstablishConnectionAsync()
        {
            while (IsStarted)
            {
                try
                {
                    var isServerReachable = await connectivityService.IsServerReachableAsync();
                    if (!isServerReachable)
                    {
                        await Delay();
                        continue;
                    }

                    if (hubConnection.State != ConnectionState.Disconnected)
                        return;

                    SetAuthorizationHeader();

                    await hubConnection.Start(new AutoTransport(new DefaultHttpClient()));
                    return;
                }
                catch (Exception exception)
                {
                    await Delay();
                    Trace(exception);
                }                
            }            
        }

        private Task CloseConnectionAsync()
        {
            return Task.Run(() => hubConnection.Stop());
        }

        private void SetAuthorizationHeader()
        {
            var tokenResponse = tokenStore.Get();
            var token = $"Bearer {tokenResponse?.AccessToken}";
            hubConnection.Headers["Authorization"] = token;
        }        

        private void SubscribeProxy()
        {
            if (hubProxy == null)
            {
                hubProxy = hubConnection.CreateHubProxy(HubName);                
                localMethods = new []
                {
                    hubProxy.On<Offer>(nameof(NewOffer), data => NewOffer?.Invoke(this, data)),
                };                
            }
        }

        private void UnsubscribeProxy()
        {
            if (hubProxy != null)
            {
                foreach (var localMethod in localMethods)
                    localMethod.Dispose();

                localMethods = null;
                hubProxy = null;
            }
        }

        private static Task Delay() => Task.Delay(TimeSpan.FromSeconds(2));

        private static void Trace(Exception exception, [CallerMemberName] string caller = null)
        {
            Trace(nameof(exception), exception, caller);
        }

        private static void Trace(string key, object value, [CallerMemberName] string caller = null)
        {
            Trace(new Dictionary<string, object>
            {
                {key, value}

            }, caller);
        }

        private static void Trace(IDictionary<string, object> infos = null, [CallerMemberName] string caller = null)
        {
            infos = infos ?? new Dictionary<string, object>();

            var strings = new List<string>(infos.Select(info => $"{info.Key} = {info.Value}"));
            
            var log = string.Join(";", strings);

            Console.WriteLine($"{caller} {log};");
        }        
    }    
}
