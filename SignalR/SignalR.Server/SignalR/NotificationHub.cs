using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System;
using SignalR.Server.SignalR;

namespace SignalR.Server
{
    public class NotificationHub : Hub<IHubClient>
    {
        private readonly ConnectionRepository connectionRepository;

        public NotificationHub(ConnectionRepository connectionRepository)
        {
            this.connectionRepository = connectionRepository;
        }

        public override Task OnConnected()
        {
            var userName = GetUserName();

            connectionRepository.CreateOrUpdate(userName, Context.ConnectionId);

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            var userName = GetUserName();

            connectionRepository.Delete(userName, Context.ConnectionId);

            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            var userName = GetUserName();

            connectionRepository.CreateOrUpdate(userName, Context.ConnectionId);

            return base.OnReconnected();
        }

        private string GetUserName()
        {
            var token = Context.Headers["Authorization"];
            switch (token)
            {
                case "Bearer 1":
                    return "driver-1";
                case "Bearer 2":
                    return "driver-2";
                case "Bearer 3":
                    return "driver-3";
                default:
                    throw new ArgumentOutOfRangeException(nameof(token));
            }            
        }
    }
}
