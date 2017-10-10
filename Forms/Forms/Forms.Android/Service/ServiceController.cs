using Forms.Services;

namespace Forms.Droid.Service
{
    internal class ServiceController
    {
        private bool isStarted;

        public ServiceController(IMusicService musicService, ITrackingService trackingService, ITimingService timingService)
        {
            MusicService = musicService;
            TrackingService = trackingService;
            TimingService = timingService;
        }

        public void Start()
        {
            if (isStarted) return;

            MusicService.Start();
            TrackingService.Start();

            isStarted = true;
        }

        public void Stop()
        {
            if (!isStarted) return;

            TrackingService.Stop();
            MusicService.Stop();

            isStarted = false;
        }

        public IMusicService MusicService { get; }

        public ITimingService TimingService { get; }

        public ITrackingService TrackingService { get; }
    }
}