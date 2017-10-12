using System;
using Forms.Services;
using Plugin.Geolocator;
using Plugin.Geolocator.Abstractions;

namespace Forms.Droid.Service.Tracking
{
    internal class TrackingService : ITrackingService
    {
        public event EventHandler<(double lat, double lon)> ValueChanged;

        public event EventHandler Started;

        public event EventHandler Stoped;

        public (double lat, double lon) Value { get; private set; }

        public bool IsStarted { get; private set; }

        public void Start()
        {
            if (!CrossGeolocator.IsSupported)
                return;

            if (IsStarted) return;
        
            CrossGeolocator.Current.PositionChanged += CurrentOnPositionChanged;
            CrossGeolocator.Current.StartListeningAsync(TimeSpan.FromSeconds(2), 2, true).ConfigureAwait(false).GetAwaiter();

            IsStarted = true;
            Started?.Invoke(this, EventArgs.Empty);
        }

        private void CurrentOnPositionChanged(object sender, PositionEventArgs e)
        {
            Value = (e.Position.Latitude, e.Position.Longitude);
            ValueChanged?.Invoke(this, Value);
        }

        public void Stop()
        {
            if (!IsStarted) return;

            CrossGeolocator.Current.PositionChanged -= CurrentOnPositionChanged;
            CrossGeolocator.Current.StopListeningAsync().ConfigureAwait(false).GetAwaiter();

            IsStarted = false;
            Stoped?.Invoke(this, EventArgs.Empty);
        }
    }
}