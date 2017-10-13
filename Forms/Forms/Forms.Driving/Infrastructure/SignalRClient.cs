using System;
using System.Diagnostics;
using System.Threading.Tasks;
using Forms.Driving.Data;
using Forms.Driving.Extensions;
using Microsoft.AspNet.SignalR.Client;
using Microsoft.AspNet.SignalR.Client.Http;
using Microsoft.AspNet.SignalR.Client.Transports;

namespace Forms.Driving.Infrastructure
{
    public class SignalRClient : IDisposable
    {
        public string State => hubConnection?.State.ToString() ?? string.Empty;
        public event EventHandler<string> StateChanged;

        private const string HubName = "NotificationHub";

        private string SignalRHub => configuration.ApiAuthority;
        
        private readonly object sync = new object();
        private readonly ServiceClientConfiguration configuration;
        private readonly IConnectivityService connectivityService;
        private readonly TokenStore tokenStore;
        private readonly ILogger logger;

        private HubConnection hubConnection;
        private IHubProxy hubProxy;
        private bool tryingToReconnect;        

        public bool IsConnected => hubConnection?.State == ConnectionState.Connected;

        public event EventHandler<OrderClosedData> OrderClosed;
        public event EventHandler<ShiftClosedData> ShiftClosed;
        public event EventHandler<NewOfferData> NewOffer;
        public event EventHandler<SameCredentialData> SameCredential;
        public event EventHandler<OrderCommentData> OrderCommentReceived;
        public event EventHandler ConnectionSlow;

        public SignalRClient(ServiceClientConfiguration configuration,
                             IConnectivityService connectivityService,
                             TokenStore tokenStore,
                             ILogger logger)
        {
            this.configuration = configuration;
            this.connectivityService = connectivityService;
            this.tokenStore = tokenStore;
            this.logger = logger;            
        }

        public bool IsListening { get; private set; }
        
        public void StartListening()
        {
            lock (sync)
            {
                if (IsListening)
                    return;

                IsListening = true;                                
            }

            CreateConnection();

            EstablishSignalRConnectionAsync().Forget();
        }

        public void StopListening()
        {
            lock (sync)
            {                
                IsListening = false;                
            }

            DisposeConnection();
        }

        private void DisposeConnection()
        {                           
            if (hubConnection == null) return;                                
            hubConnection.Error -= HubConnection_Error;
            hubConnection.Reconnecting -= HubConnection_Reconnecting;
            hubConnection.Reconnected -= HubConnection_Reconnected;
            hubConnection.Closed -= HubConnection_Closed;
            hubConnection.StateChanged -= HubConnection_StateChanged;
            hubConnection.ConnectionSlow -= HubConnection_ConnectionSlow;
            hubConnection.Dispose();
            hubProxy = null;
            hubConnection = null;            
        }

        private void CreateConnection()
        {            
            hubConnection = new HubConnection(SignalRHub, true);                      
            hubConnection.Error += HubConnection_Error;
            hubConnection.Reconnecting += HubConnection_Reconnecting;
            hubConnection.Reconnected += HubConnection_Reconnected;            
            hubConnection.Closed += HubConnection_Closed;
            hubConnection.StateChanged += HubConnection_StateChanged;            
            hubConnection.ConnectionSlow += HubConnection_ConnectionSlow;
        }

        private void HubConnection_ConnectionSlow()
        {
            ConnectionSlow?.Invoke(this, EventArgs.Empty);
        }
        
        private void HubConnection_StateChanged(StateChange stateChange)
        {
            Debug.WriteLine($"{stateChange.OldState} -> {stateChange.NewState}");

            StateChanged?.Invoke(this, stateChange.NewState.ToString());
        }

        private void HubConnection_Reconnected()
        {
            tryingToReconnect = false;            
        }

        private void HubConnection_Reconnecting()
        {
            tryingToReconnect = true;                        
        }

        private void HubConnection_Closed()
        {                       
            Debug.WriteLine(hubConnection.LastError.Message);

            if (!tryingToReconnect)
                return;

            EstablishSignalRConnectionAsync().Forget();
        }

        private void Subscibe(HubConnection connection)
        {
            if (hubProxy != null) return;

            hubProxy = connection.CreateHubProxy(HubName);
                
            hubProxy.On<NewOfferData>("NewOffer", data => NewOffer?.Invoke(this, data));
            hubProxy.On<SameCredentialData>("SameCredential", data => SameCredential?.Invoke(this, data));
            hubProxy.On<ShiftClosedData>("ShiftClosed", data => ShiftClosed?.Invoke(this, data));
            hubProxy.On<OrderClosedData>("OrderClosed", data => OrderClosed?.Invoke(this, data));
            hubProxy.On<OrderCommentData>("NewOrderComment", data => OrderCommentReceived?.Invoke(this, data));
        }

        private void HubConnection_Error(Exception exception)
        {
            Debug.WriteLine(exception.Message);

            logger.Error(exception);
            
            if (!hubConnection.EnsureReconnecting())
                EstablishSignalRConnectionAsync().Forget();
        }        

        private readonly CasExecutor establishing = new CasExecutor();

        private async Task EstablishSignalRConnectionAsync()
        {
            await establishing.ExecuteAsync(SafeStartListeningAsync);
        }

        private async Task SafeStartListeningAsync()
        {
            var duration = MinDelayDuration;
            for (;;)
            {
                try
                {
                    if (connectivityService.IsConnected)
                    {
                        var isServerReachable = await connectivityService.IsServerReachableAsync();
                        if (!isServerReachable)
                        {
                            duration = await Delay(duration);
                            continue;
                        }

                        SetAuthorizationHeader();

                        Subscibe(hubConnection);
                        await hubConnection.Start(new AutoTransport(new DefaultHttpClient()));
                        
                        break;
                    }

                    duration = await Delay(duration);
                }
                catch (Exception exception)
                {
                    duration = await Delay(duration);
                    logger.Error(exception);
                }
            } 
        }


        private static readonly TimeSpan MinDelayDuration = TimeSpan.FromSeconds(2);
        private static readonly TimeSpan MaxDelayDuration = TimeSpan.FromSeconds(8);

        private static async Task<TimeSpan> Delay(TimeSpan duration)
        {
            await Task.Delay(duration);

            var newDuration = TimeSpan.FromSeconds(duration.TotalSeconds * 1.5);

            return newDuration < MaxDelayDuration ? newDuration : MaxDelayDuration;
        }

        private void SetAuthorizationHeader()
        {
            const string authorizationHeaderName = "Authorization";
            var tokenResponse = tokenStore.Get();
            var token = $"Bearer {tokenResponse?.AccessToken}";            
            hubConnection.Headers.Remove(authorizationHeaderName);
            hubConnection.Headers.Add(authorizationHeaderName, token);                       
        }
        
        private bool disposed;

        public void Dispose()
        {
            Dispose(true);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                StopListening();                                                                  

                GC.SuppressFinalize(this);
            }

            disposed = true;
        }        
    }
}
