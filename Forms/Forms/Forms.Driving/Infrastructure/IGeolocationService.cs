using System;
using System.Threading.Tasks;
using Forms.Driving.Domain;

namespace Forms.Driving.Infrastructure
{
    public interface IGeolocationService : IDisposable
    {
        event EventHandler<GeoLocation> LocationChanged;

        event EventHandler<LocationError> LocationErrorAction;

        bool IsGeolocationAvailable { get; }
        
        bool IsGeolocationEnabled { get; }

        Task StartAsync(TimeSpan period, double accuracyMeters);

        Task StopAsync();
    }
}