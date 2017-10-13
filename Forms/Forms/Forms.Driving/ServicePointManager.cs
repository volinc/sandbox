using Forms.Driving.Infrastructure;

namespace Forms.Driving
{
    public class ServicePointManager : IServicePointManager
    {
        public int DnsRefreshTimeout { get; set; }
    }
}
