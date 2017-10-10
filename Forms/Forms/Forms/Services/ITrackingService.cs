using System;

namespace Forms.Services
{
    public interface ITrackingService
    {
        (double lat, double lon) Value { get; }

        event EventHandler<(double lat, double lon)> ValueChanged;

        event EventHandler Started;

        event EventHandler Stoped;

        void Start();

        void Stop();
    }
}
