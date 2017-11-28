using System.Threading.Tasks;
using Android.App;
using Com.Taxys.Tinkoff;
using Forms.Infrastructure;

namespace Forms.Droid
{
    internal class PlatformNotifier : IPlatformNotifier
    {
        //https://stackoverflow.com/questions/39479508/show-dialog-activity-over-another-app-from-background
        public async Task<bool> ShowDialogAsync(string message)
        {
            await Task.Delay(0);

            var context = Application.Context as Activity;

            const string terminalKey = "sdk3DS";
            const string password = "12345678";
            const string publicKey =
                "MIIBIjANBgkqhkiG9w0BAQEFAAOCAQ8AMIIBCgKCAQEAqBiorLS9OrFPezixO5lSsF+HiZPFQWDO\n" +
                "7x8gBJp4m86Wwz7ePNE8ZV4sUAZBqphdqSpXkybM4CJwxdj5R5q9+RHsb1dbMjThTXniwPpJdw4W\n" +
                "KqG5/cLDrPGJY9NnPifBhA/MthASzoB+60+jCwkFmf8xEE9rZdoJUc2p9FL4wxKQPOuxCqL2iWOx\n" +
                "AO8pxJBAxFojioVu422RWaQvoOMuZzhqUEpxA9T62lN8t3jj9QfHXaL4Ht8kRaa2JlaURtPJB5iB\n" +
                "M+4pBDnqObNS5NFcXOxloZX4+M8zXaFh70jqWfiCzjyhaFg3rTPE2ClseOdS7DLwfB2kNP3K0GuP\n" +
                "uLzsMwIDAQAB";

            const string customerKey = "1";
            const string orderId = "1";
            var amount = new Java.Lang.Double(100.0d);
            const string title = "Title ---";
            const string description = "Description ---";
            const string email = "vol.inc@gmail.com";
            
            var ta = new TinkoffAcquiring();
            ta.InitPayment(context, 
                           terminalKey,
                           password,
                           publicKey,
                           customerKey,
                           orderId,
                           amount,
                           title,
                           description,
                           email);

            return true;
        }
    }
}