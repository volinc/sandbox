using System.Windows.Input;
using Forms.Helpers;
using Forms.Infrastructure;
using Forms.Services;
using Xamarin.Forms;

namespace Forms.ViewModels
{
    public class TrackingViewModel : BaseViewModel
    {
        private readonly IPermissionsManager _permissionsManager;
        private readonly ITrackingService _trackingService;
        private readonly ITimingService _timingService;
        
        public TrackingViewModel(IRegistry registry, IPermissionsManager permissionsManager)
        {            
            _trackingService = registry.TrackingService;
            _trackingService.ValueChanged += TrackingServiceOnValueChanged;

            _timingService = registry.TimingService;
            _timingService.ValueChanged += TimingServiceOnValueChanged;

            _permissionsManager = permissionsManager;
        }

        private void TimingServiceOnValueChanged(object sender, int i)
        {
            Second = i;
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

        private int _second;
        public int Second
        {
            get => _second;
            set => SetProperty(ref _second, value);
        }

        public ICommand CheckPermissionsCommand => new Command(async () => await _permissionsManager.CheckPermissionsAsync());

        public override void Dispose()
        {
            _timingService.ValueChanged -= TimingServiceOnValueChanged;
            _trackingService.ValueChanged -= TrackingServiceOnValueChanged;

            base.Dispose();            
        }
    }
}
