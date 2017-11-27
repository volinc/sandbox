using System;
using System.Threading.Tasks;
using Android.App;
using Android.Content;
using Forms.Infrastructure;

namespace Forms.Droid
{
    internal class PlatformNotifier : IPlatformNotifier
    {
        //https://stackoverflow.com/questions/39479508/show-dialog-activity-over-another-app-from-background
        public async Task<bool> ShowDialogAsync(string message)
        {
            await Task.Delay(TimeSpan.FromSeconds(5));

            var context = Application.Context;

            var dialogIntent = new Intent(context, typeof(OfferActivity));
            dialogIntent.AddFlags(ActivityFlags.ReorderToFront | ActivityFlags.NewTask);

            context.StartActivity(dialogIntent);
            
            return true;
        }
    }
}