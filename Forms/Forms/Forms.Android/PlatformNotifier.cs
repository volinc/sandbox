using System.Threading.Tasks;
using Forms.Infrastructure;
using Plugin.CurrentActivity;

namespace Forms.Droid
{
    internal class PlatformNotifier : IPlatformNotifier
    {
        public async Task<bool> ShowDialogAsync(string message)
        {
            var mainActivity = CrossCurrentActivity.Current.Activity;

            //https://stackoverflow.com/questions/39479508/show-dialog-activity-over-another-app-from-background

            await Task.Delay(0);
        }
    }
}