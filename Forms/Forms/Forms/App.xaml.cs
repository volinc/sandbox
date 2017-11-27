using System;
using System.Threading.Tasks;
using Autofac;
using Forms.Infrastructure;
using Forms.ViewModels;
using Forms.Views;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms
{
    public partial class App : IDisposable
    {
        public static ViewModelFactory ViewModelFactory { get; private set; }

        private readonly IContainer _container;
        private readonly IRegistry _registry;

        public App(Module module)
        {
            InitializeComponent();

            _container = CreateContainer(module);

            _registry = _container.Resolve<IRegistry>();
            _registry.Connected += RegistryOnConnected;
            _registry.Disconnected += RegistryOnDisconnected;

            ViewModelFactory = _container.Resolve<ViewModelFactory>();

            MainPage = new LoadingPage();
        }

        public void Dispose()
        {
            _registry.Connected -= RegistryOnConnected;
            _registry.Disconnected -= RegistryOnDisconnected;
            _container?.Dispose();
        }

        private static IContainer CreateContainer(params Module[] modules)
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<TrackingViewModel>().InstancePerDependency();
            builder.RegisterType<ViewModelFactory>().AsSelf().SingleInstance();

            foreach (var module in modules)
                builder.RegisterModule(module);

            return builder.Build();
        }

        private void RegistryOnDisconnected(object sender, EventArgs eventArgs)
        {
            MainPage = new UnexpectedErrorPage();
        }

        private async void RegistryOnConnected(object sender, EventArgs eventArgs)
        {
            await Task.Delay(TimeSpan.FromSeconds(3));

            MainPage = new TrackingPage();
        }
    }
}