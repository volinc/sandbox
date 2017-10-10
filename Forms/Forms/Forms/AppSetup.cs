using Autofac;
using Forms.ViewModels;

namespace Forms
{
    public class AppSetup
    {
        public IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();
            RegisterDependencies(containerBuilder);
            return containerBuilder.Build();
        }

        protected virtual void RegisterDependencies(ContainerBuilder builder)
        {
            builder.RegisterType<TrackingViewModel>().InstancePerDependency();
            builder.RegisterType<ViewModelFactory>().SingleInstance();
        }
    }
}
