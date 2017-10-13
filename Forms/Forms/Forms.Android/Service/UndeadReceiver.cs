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
        "android.provider.Telephony.SMS_RECEIVED",
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
            Toast.MakeText(context, $"Received intent! {intent.Action}", ToastLength.Short).Show();

            switch (intent.Action)
            {
                case Intent.ActionReboot:
                case Intent.ActionBootCompleted:
                case Intent.ActionLockedBootCompleted:
                case ActionQuickbootPowerOn:
                case ActionHtcQuickbootPowerOn:
                    var serviceIntent = new Intent(context, typeof(UndeadService));
                    context.StartService(serviceIntent);
                    break;
            }
        }        
    }
}