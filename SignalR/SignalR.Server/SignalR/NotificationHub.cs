using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;

namespace SignalR.Server
{
    [Authorize]
    public class NotificationHub : Hub<INotificationHubProxy>
    {
        public override Task OnConnected()
        {        
            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {         
            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {         
            return base.OnReconnected();
        }        
    }
}
