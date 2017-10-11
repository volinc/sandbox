using System;
using System.Threading;
using System.Threading.Tasks;
using Android;
using Android.App;

using Android.OS;
using Android.Support.Design.Widget;
using Android.Support.V4.App;
using Android.Support.V4.Content;
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
            try
            {
                if (Build.VERSION.SdkInt < BuildVersionCodes.M)
                {
                    var context = CrossCurrentActivity.Current.Activity;

                    const string permission = Manifest.Permission.AccessFineLocation;
                    var checkResult = ContextCompat.CheckSelfPermission(context, permission);
                    if (checkResult == Android.Content.PM.Permission.Granted)
                        return;

                    const int requestCode = 8000;

                    if (ActivityCompat.ShouldShowRequestPermissionRationale(context, permission))
                    {
                        var activityView = GetActivityView();

                        Snackbar.Make(activityView, "Location access is required to show coffee shops nearby.", Snackbar.LengthLong)                            
                            .SetAction("Allow", view => ActivityCompat.RequestPermissions(context, new[] { Manifest.Permission.AccessFineLocation }, requestCode))
                            //OpenPermissionSettings())
                            .Show();

                        return;
                    }

                    ActivityCompat.RequestPermissions(context, new [] { Manifest.Permission.AccessFineLocation }, requestCode);
                }

                var status = await CrossPermissions.Current.CheckPermissionStatusAsync(Permission.Location);
                if (status != PermissionStatus.Granted)
                {
                    if (await CrossPermissions.Current.ShouldShowRequestPermissionRationaleAsync(Permission.Location))
                    {
                        await DisplayAlert("Need location", "Gunna need that location");
                    }

                    var results = await CrossPermissions.Current.RequestPermissionsAsync(Permission.Location);
                    //Best practice to always check that the key exists
                    if (results.ContainsKey(Permission.Location))
                        status = results[Permission.Location];
                }

                if (status == PermissionStatus.Granted)
                {
                    //var results = await CrossGeolocator.Current.GetPositionAsync(TimeSpan.FromSeconds(10));
                    //var text = "Lat: " + results.Latitude + " Long: " + results.Longitude;
                    const string text = "---";
                    await DisplayAlert("Granted", text);
                }
                else if (status != PermissionStatus.Unknown)
                {
                    await DisplayAlert("Location Denied", "Can not continue, try again.");
                }
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

        private static Activity GetCurrentActivity()
        {
            return CrossCurrentActivity.Current.Activity;
        }

        private static Android.Views.View GetActivityView()
        {
            return GetCurrentActivity().FindViewById(Android.Resource.Id.Content);
        }

        //private static void OpenPermissionSettings()
        //{
        //    var context = Android.App.Application.Context;

        //    var packageName = context.PackageName;
        //    var uri = Android.Net.Uri.Parse("package:" + packageName);
        //    var intent = new Intent(Android.Provider.Settings.ActionApplicationDetailsSettings, uri);

        //    // Этот флаг надо поставить, иначе Andorid выбросит исключение.
        //    // Подробности: https://forums.xamarin.com/discussion/10232/calling-startactivity-from-outside-of-an-activity-context-requires-the-flag-activity-new-task-flag
        //    intent.AddFlags(ActivityFlags.NewTask);

        //    context.StartActivity(intent);
        //}
    }
}