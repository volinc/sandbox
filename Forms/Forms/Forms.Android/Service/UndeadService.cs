using Android.App;
using Android.Content;
using Android.OS;
using Autofac;
using Forms.Droid.Service.Music;
using Forms.Droid.Service.Timing;
using Forms.Droid.Service.Tracking;

namespace Forms.Droid.Service
{
    [Service(Enabled = true, Exported = false, Label = nameof(UndeadService))]
    internal class UndeadService : Android.App.Service
    {
        private readonly IContainer container;
        private readonly IBinder binder;

        public ServiceController Controller { get; }

        public UndeadService()
        {
            binder = new UndeadServiceBinder(this);

            container = CreateContainer();

            Controller = container.Resolve<ServiceController>();            
        }

        public override void OnCreate() => base.OnCreate();

        public override StartCommandResult OnStartCommand(Intent intent, StartCommandFlags flags, int startId)
        {
            StartForeground();

            Controller.Start();

            return StartCommandResult.Sticky;
        }

        public override IBinder OnBind(Intent intent) => binder;

        public override bool OnUnbind(Intent intent) => base.OnUnbind(intent);

        public override void OnDestroy() => base.OnDestroy();

        private IContainer CreateContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<ServiceController>().SingleInstance();
            builder.RegisterType<MusicService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<TrackingService>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<TimingService>().AsImplementedInterfaces().SingleInstance();
            
            return builder.Build();
        }

        private void StartForeground()
        {
            var context = Application.Context;
            var notificationIntent = new Intent(context, typeof(MainActivity));            
            var pendingIntent = PendingIntent.GetActivity(context, 0, notificationIntent, 0);

            const int notificationId = 10000;
            const string title = "Undead service";
            const string text = "...";

            var notification = new Notification.Builder(context)
                .SetAutoCancel(false)
                .SetContentIntent(pendingIntent)
                .SetContentTitle(title)
                .SetContentText(text)
                .SetSmallIcon(Android.Resource.Drawable.SymDefAppIcon)
                .Build();
            
            StartForeground(notificationId, notification);
        }
    }
}