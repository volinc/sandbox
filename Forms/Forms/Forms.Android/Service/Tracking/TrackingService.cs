using System;
using Forms.Services;

namespace Forms.Droid.Service.Tracking
{
    internal class TrackingService : ITrackingService
    {
        public (double lat, double lon) Value { get; private set; }

        public event EventHandler<(double lat, double lon)> ValueChanged;

        public event EventHandler Started;

        public event EventHandler Stoped;

        public void Start()
        {
            
        }

        public void Stop()
        {
            
        }
    }
}