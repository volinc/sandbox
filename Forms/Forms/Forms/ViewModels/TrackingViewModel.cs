using Forms.Helpers;
using Forms.Infrastructure;
using Forms.Services;

namespace Forms.ViewModels
{
    public class TrackingViewModel : BaseViewModel
    {
        private readonly ITrackingService _trackingService;
        
        public TrackingViewModel(IRegistry registry)
        {
            _trackingService = registry.TrackingService;
            _trackingService.ValueChanged += TrackingServiceOnValueChanged;
        }

        private void TrackingServiceOnValueChanged(object sender, (double lat, double lon) location)
        {
            Lat = location.lat;
            Lon = location.lon;
        }

        private double _lat;
        public double Lat
        {
            get => _lat;
            set => SetProperty(ref _lat, value);
        }

        private double _lon;
        public double Lon
        {
            get => _lon;
            set => SetProperty(ref _lon, value);
        }

        public override void Dispose()
        {
            _trackingService.ValueChanged -= TrackingServiceOnValueChanged;

            base.Dispose();            
        }
    }
}
