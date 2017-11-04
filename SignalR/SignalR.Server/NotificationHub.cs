using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System.Linq;
using System;

namespace SignalR.Server
{
    public class NotificationHub : Hub<INotificationHub>
    {
        private readonly static ConnectionMapping<string> _connections =
            new ConnectionMapping<string>();

        public override Task OnConnected()
        {
            var client = GetClient();

            _connections.Add(client.userName, Context.ConnectionId);

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var client = GetClient();

            _connections.Remove(client.userName, Context.ConnectionId);

            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            var client = GetClient();

            if (!_connections.GetConnections(client.userName).Contains(Context.ConnectionId))
            {
                _connections.Add(client.userName, Context.ConnectionId);
            }

            return base.OnReconnected();
        }
        
        private (string userName, string userAgent) GetClient()
        {
            var token = Context.Headers["Authorization"];

            switch (token)
            {
                case "Bearer 1":
                    return (userName: "driver-1", userAgent: "driver-mobile");
                case "Bearer 2":
                    return (userName: "driver-2", userAgent: "driver-mobile");
                case "Bearer 3":
                    return (userName: "driver-3", userAgent: "driver-mobile");
                default:
                    throw new ArgumentOutOfRangeException(nameof(token));
            }            
        }
    }
}
