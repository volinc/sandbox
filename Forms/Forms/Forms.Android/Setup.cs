using Autofac;

namespace Forms.Droid
{
    internal class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder builder)
        {
            base.RegisterDependencies(builder);

            builder.RegisterType<PlatformNotifier>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<PlatformPermissions>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<Registry>().AsImplementedInterfaces().SingleInstance();            
        }
    }
}