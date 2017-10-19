using System.Windows.Input;
using Forms.Helpers;
using Forms.Infrastructure;
using Forms.Services;
using Xamarin.Forms;
using PropertyChanged;

namespace Forms.ViewModels
{
    public class TrackingViewModel : BaseViewModel
    {
        private readonly IPlatformPermissions _platformPermissions;
        private readonly IPlatformNotifier _platformNotifier;
        private readonly ITrackingService _trackingService;
        private readonly ITimingService _timingService;
        
        public TrackingViewModel(IRegistry registry, IPlatformPermissions platformPermissions, IPlatformNotifier platformNotifier)
        {            
            _trackingService = registry.TrackingService;
            _trackingService.ValueChanged += TrackingServiceOnValueChanged;

            _timingService = registry.TimingService;
            _timingService.ValueChanged += TimingServiceOnValueChanged;

            _platformPermissions = platformPermissions;
            _platformNotifier = platformNotifier;
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

        public double Lat { get; set; }

        public double Lon { get; set; }

        public int Second { get; set; }

        [AlsoNotifyFor(nameof(IsCommandEnabled))]
        public override bool IsBusy
        {
            get => base.IsBusy;
            set => base.IsBusy = value;
        }

        public bool IsCommandEnabled => !IsBusy;

        public ICommand CheckPermissionsCommand => new Command(async () =>
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                await _platformPermissions.RequestLocationAsync();
                await _platformPermissions.RequestSmsAsync();
            }
            finally
            {
                IsBusy = false;
            }
        });

        public ICommand ShowOfferDialogCommand => new Command(async () =>
        {
            if (IsBusy) return;

            try
            {
                IsBusy = true;

                await _platformNotifier.ShowDialogAsync("Offfffeeeeeeeeer!!!");
            }
            finally
            {
                IsBusy = false;
            }
        });

        public override void Dispose()
        {
            _timingService.ValueChanged -= TimingServiceOnValueChanged;
            _trackingService.ValueChanged -= TrackingServiceOnValueChanged;

            base.Dispose();            
        }
    }
}
