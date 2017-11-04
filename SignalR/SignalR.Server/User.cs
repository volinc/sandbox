using System.Collections.Generic;

namespace SignalR.Server
{
    public class User
    {
        public string UserName { get; set; }
        public ICollection<Connection> Connections { get; set; }
    }
}
