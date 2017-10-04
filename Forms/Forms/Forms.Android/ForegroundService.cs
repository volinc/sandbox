using System;
using Android.App;
using Android.Content;
using Android.OS;

namespace Forms.Droid
{
    public class ForegroundService : Service
    {
        public override IBinder OnBind(Intent intent)
        {
            throw new NotImplementedException();
        }
    }
}