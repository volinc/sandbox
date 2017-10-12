using System;
using Autofac;
using Forms.Infrastructure;
using Forms.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms
{
    public partial class App : Application, IDisposable
    {
        private readonly IContainer _container;
        private readonly IRegistry _registry;

        public static ViewModelFactory ViewModelFactory { get; private set; }

        public App(AppSetup setup)
        {
            InitializeComponent();

            _container = setup.CreateContainer();

            _registry = _container.Resolve<IRegistry>();
            _registry.Connected += RegistryOnConnected;
            _registry.Disconnected += RegistryOnDisconnected;

            ViewModelFactory = _container.Resolve<ViewModelFactory>();

            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = { new Label { Text = "Loading..." } }
                }
            };
        }

        private void RegistryOnDisconnected(object sender, EventArgs eventArgs)
        {
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = { new Label { Text = "Disconnected" } }
                }
            };
        }

        private void RegistryOnConnected(object sender, EventArgs eventArgs)
        {
            MainPage = new TrackingPage();
        }

        public void Dispose()
        {
            _registry.Connected -= RegistryOnConnected;
            _registry.Disconnected -= RegistryOnDisconnected;
            _container?.Dispose();
        }
    }
}
