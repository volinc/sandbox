using Forms.Services;

namespace Forms.Droid.Service
{
    internal class ServiceController
    {
        private bool _isStarted;

        public ServiceController(IMusicService musicService, ITrackingService trackingService, ITimingService timingService)
        {
            MusicService = musicService;
            TrackingService = trackingService;
            TimingService = timingService;            
        }

        public void Start()
        {
            if (_isStarted) return;

            MusicService.Start();
            TrackingService.Start();
            TimingService.Start();                

            _isStarted = true;
        }

        public void Stop()
        {
            if (!_isStarted) return;

            DrivingService.Stop();
            TimingService.Stop();
            TrackingService.Stop();
            MusicService.Stop();

            _isStarted = false;
        }

        public IMusicService MusicService { get; }

        public ITimingService TimingService { get; }

        public ITrackingService TrackingService { get; }

        public IDrivingService DrivingService { get; }
    }
}