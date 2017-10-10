using Android.App;
using Android.Content;
using Android.OS;

namespace Forms.Droid.Service
{
    internal abstract class UndeadServiceConnection : Java.Lang.Object, IServiceConnection
    {
        protected UndeadServiceBinder Binder { get; private set; }
        protected bool IsBound { get; private set; }
        
        protected void Open()
        {
            var context = Application.Context;
            var serviceIntent = new Intent(context, typeof(UndeadService));
            context.StartService(serviceIntent);
            context.BindService(serviceIntent, this, Bind.AutoCreate);
        }
        protected void Close()
        {
            if (IsBound)
            {
                var context = Application.Context;
                context.UnbindService(this);
            }            
        }

        public virtual void OnServiceConnected(ComponentName name, IBinder service)
        {
            Binder = service as UndeadServiceBinder;
            if (Binder != null)                
                IsBound = true;           
        }

        public virtual void OnServiceDisconnected(ComponentName name)
        {
            IsBound = false;
        }

        protected override void Dispose(bool disposing)
        {
            Close();

            base.Dispose(disposing);
        }
    }
}