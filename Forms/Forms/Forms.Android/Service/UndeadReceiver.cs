using System;
using System.Linq;
using Android.App;
using Android.Content;
using Android.Widget;

namespace Forms.Droid.Service
{
    [BroadcastReceiver(Enabled = true, Exported = true, Label = nameof(UndeadReceiver))]
    [IntentFilter(new[]
    {
        Intent.ActionReboot,
        Intent.ActionBootCompleted,
        Intent.ActionLockedBootCompleted,
        ActionQuickbootPowerOn,
        ActionHtcQuickbootPowerOn,        
    })]
    public class UndeadReceiver : BroadcastReceiver
    {
        public const string ActionQuickbootPowerOn = "android.intent.action.QUICKBOOT_POWERON";
        public const string ActionHtcQuickbootPowerOn = "com.htc.intent.action.QUICKBOOT_POWERON";

        public override void OnReceive(Context context, Intent intent)
        {
            if (!IsKnownAction(intent.Action)) return;

            Toast.MakeText(context, $"Received intent! {intent.Action}", ToastLength.Short).Show();
            
            var serviceIntent = new Intent(context, typeof(UndeadService));
            context.StartService(serviceIntent);            
        }

        private bool IsKnownAction(string action)
        {
            var knownActions = GetType().GetCustomAttributes(false)
                .OfType<IntentFilterAttribute>()
                .SelectMany(x => x.Actions);

            return knownActions.Contains(action, StringComparer.OrdinalIgnoreCase);
        }
    }
}