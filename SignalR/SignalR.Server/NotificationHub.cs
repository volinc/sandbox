using System.Threading.Tasks;
using Microsoft.AspNet.SignalR;
using System;
using System.Runtime.CompilerServices;
using System.Collections.Generic;

namespace SignalR.Server
{
    public class NotificationHub : Hub
    {
        public override Task OnConnected()
        {
            Trace(new Dictionary<string, object>
            {
                { nameof(Context.ConnectionId), Context.ConnectionId }
            });

            return base.OnConnected();
        }

        public override Task OnDisconnected(bool stopCalled)
        {
            Trace(new Dictionary<string, object>
            {
                { nameof(Context.ConnectionId), Context.ConnectionId }
            });

            return base.OnDisconnected(stopCalled);
        }

        public override Task OnReconnected()
        {
            Trace(new Dictionary<string, object>
            {
                { nameof(Context.ConnectionId), Context.ConnectionId }
            });

            return base.OnReconnected();
        }

        private void Trace(IDictionary<string, object> infos, [CallerMemberName] string caller = null)
        {
            var strings = new List<string>(infos.Count);
            foreach (var info in infos)
                strings.Add($"{info.Key}={info.Value}");

            var log = string.Join(";", strings);

            Console.WriteLine($"{caller}: {log};");
        }
    }
}
