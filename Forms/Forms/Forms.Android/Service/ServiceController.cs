using Forms.Services;

namespace Forms.Droid.Service
{
    internal class ServiceController
    {
        private bool isStarted;

        public void Start()
        {
            if (isStarted) return;

            isStarted = true;
        }

        public void Stop()
        {
            if (!isStarted) return;

            isStarted = false;
        }

        public IMusicService MusicService { get; }

        public ITimingService TimingService { get; }

        public ITrackingService TrackingService { get; }
    }
}