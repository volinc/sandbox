using Android.OS;
using Forms.Services;

namespace Forms.Droid
{
    internal class TServiceBinder : Binder
    {
        private readonly TService service;

        public TServiceBinder(TService service)
        {
            this.service = service;
        }

        public IMusicService MusicService => service.Controller.MusicService;

        public ITimingService TimingService => service.Controller.TimingService;

        public ITrackingService TrackingService => service.Controller.TrackingService;
    }
}