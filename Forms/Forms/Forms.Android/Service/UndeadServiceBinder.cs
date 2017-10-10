using Android.OS;
using Forms.Services;

namespace Forms.Droid.Service
{
    internal class UndeadServiceBinder : Binder
    {
        private readonly UndeadService service;

        public UndeadServiceBinder(UndeadService service)
        {
            this.service = service;
        }

        public IMusicService MusicService => service.Controller.MusicService;

        public ITimingService TimingService => service.Controller.TimingService;

        public ITrackingService TrackingService => service.Controller.TrackingService;
    }
}