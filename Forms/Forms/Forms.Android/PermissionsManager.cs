using System;
using System.Threading;
using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Forms.Infrastructure;
using Plugin.CurrentActivity;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using AlertDialog = Android.Support.V7.App.AlertDialog;

namespace Forms.Droid
{
    internal class PermissionsManager : IPermissionsManager
    {
        public async Task CheckPermissionsAsync()
        {
            if (Build.VERSION.SdkInt < BuildVersionCodes.M)
                return;

            try
            {
                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need location", "Gunna need that location");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);                    
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                    return;

                if (status != PermissionStatus.Unknown)
                    await DisplayAlert("Location Denied", "Can not continue, try again.");                
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.ToString());
            }
        }

        private static async Task DisplayAlert(string title, string message)
        {
            var manualResetEvent = new ManualResetEventSlim(false);

            var context = GetCurrentActivity();
            var builder = new AlertDialog.Builder(context);
            builder.SetTitle(title);
            builder.SetMessage(message);
            builder.SetPositiveButton("OK", (sender, args) =>
            {
                manualResetEvent.Set();
            });

            var alertDialog = builder.Create();
            await Task.Run(() =>
            {
                Device.BeginInvokeOnMainThread(() => alertDialog.Show());
                manualResetEvent.Wait();
            });            
        }

        private static Activity GetCurrentActivity() => CrossCurrentActivity.Current.Activity;
    }
}