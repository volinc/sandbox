using Forms.Services;

namespace Forms.Droid.Service
{
    internal class ServiceController
    {
        private readonly IMusicService _musicService;

        private bool isStarted;

        public ServiceController(IMusicService musicService)
        {
            _musicService = musicService;
        }

        public void Start()
        {
            if (isStarted) return;

            _musicService.Start();

            isStarted = true;
        }

        public void Stop()
        {
            if (!isStarted) return;

            _musicService.Stop();

            isStarted = false;
        }

        public IMusicService MusicService { get; }

        public ITimingService TimingService { get; }

        public ITrackingService TrackingService { get; }
    }
}