using Autofac;

namespace Forms.Droid
{
    internal class IocModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<PlatformNotifier>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<PlatformPermissions>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<Registry>().AsImplementedInterfaces().SingleInstance();
        }
    }
}