using System;
using System.Threading.Tasks;
using System.Windows.Input;
using Forms.Helpers;
using Forms.Infrastructure;
using Forms.Services;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;

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

        public ICommand CheckPermissionsCommand => new Command(async () => await CheckPermissions());

        private static async Task CheckPermissions()
        {
            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await Application.Current.MainPage.DisplayAlert("Need location", "Gunna need that location", "OK");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    //Best practice to always check that the key exists
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    var results = await CrossGeolocator.Current.GetPositionAsync(TimeSpan.FromSeconds(10));
                    var text = "Lat: " + results.Latitude + " Long: " + results.Longitude;
                    await Application.Current.MainPage.DisplayAlert("Granted", text, "OK");
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await Application.Current.MainPage.DisplayAlert("Location Denied", "Can not continue, try again.", "OK");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.ToString(), "OK");
            }
        }

        public override void Dispose()
        {
            _trackingService.ValueChanged -= TrackingServiceOnValueChanged;

            base.Dispose();            
        }
    }
}
