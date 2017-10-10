using Autofac;

namespace Forms.Droid
{
    internal class Setup : AppSetup
    {
        protected override void RegisterDependencies(ContainerBuilder builder)
        {
            base.RegisterDependencies(builder);

            builder.RegisterType<Registry>().AsImplementedInterfaces().SingleInstance();
        }
    }
}