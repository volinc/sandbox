using System;

namespace Forms.Services
{
    public interface ITrackingService
    {
        event EventHandler<(double lat, double lon)> ValueChanged;

        event EventHandler Started;

        event EventHandler Stoped;

        (double lat, double lon) Value { get; }

        bool IsStarted { get; }

        void Start();

        void Stop();
    }
}
