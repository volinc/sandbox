using Android.Content;
using Android.OS;
using Autofac;
using Forms.Droid.Service;

namespace Forms.Droid
{
    internal class TService : Android.App.Service
    {
        private readonly IContainer container;
        private readonly IBinder binder;

        public ServiceController Controller { get; }

        public TService()
        {
            binder = new TServiceBinder(this);

            var builder = new ContainerBuilder();
            builder.RegisterType<ServiceController>();
            container = builder.Build();

            Controller = container.Resolve<ServiceController>();            
        }

        public override void OnCreate() => base.OnCreate();

        public override IBinder OnBind(Intent intent) => binder;

        public override bool OnUnbind(Intent intent) => base.OnUnbind(intent);

        public override void OnDestroy() => base.OnDestroy();
    }
}