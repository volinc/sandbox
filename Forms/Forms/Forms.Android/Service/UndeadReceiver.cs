using System.Linq;
using Android.App;
using Android.Content;
using Android.Provider;
using Android.Widget;
using Xamarin.Forms;

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
        ActionSmsReceived
    })]
    public class UndeadReceiver : BroadcastReceiver
    {
        private const string ActionQuickbootPowerOn = "android.intent.action.QUICKBOOT_POWERON";
        private const string ActionHtcQuickbootPowerOn = "com.htc.intent.action.QUICKBOOT_POWERON";
        private const string ActionSmsReceived = "android.provider.Telephony.SMS_RECEIVED";

        private static readonly string[] Senders = { "Prestige", "Banana.Taxi", "1234" };

        public override void OnReceive(Context context, Intent intent)
        {
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
                case ActionSmsReceived:
                    var messages = Telephony.Sms.Intents.GetMessagesFromIntent(intent);
                    var message = messages
                        .Where(x => Senders.Contains(x.OriginatingAddress))
                        .OrderByDescending(x => x.TimestampMillis)
                        .First();

                    Toast.MakeText(context, message.MessageBody, ToastLength.Long).Show();
                    MessagingCenter.Send(this, nameof(ActionSmsReceived), message.MessageBody);
                    break;
            }
        }
    }
}