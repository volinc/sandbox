using Forms.Services;

namespace Forms.Droid.Service
{
    internal class ServiceController
    {
        public IMusicService MusicService { get; }

        public ITimingService TimingService { get; }

        public ITrackingService TrackingService { get; }
    }
}