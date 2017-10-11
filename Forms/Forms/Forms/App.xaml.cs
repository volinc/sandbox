using System;
using Autofac;
using Forms.Infrastructure;
using Forms.Views;
using Plugin.Geolocator;
using Plugin.Permissions;
using Plugin.Permissions.Abstractions;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms
{
    public partial class App : Application
    {
        private readonly IContainer container;
        private IRegistry registry;

        public static ViewModelFactory ViewModelFactory { get; private set; }

        public App(AppSetup setup)
        {
            InitializeComponent();

            container = setup.CreateContainer();

            registry = container.Resolve<IRegistry>();
            registry.Connected += RegistryOnConnected;
            registry.Disconnected += RegistryOnDisconnected;

            ViewModelFactory = container.Resolve<ViewModelFactory>();

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

            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        Children = { new Label { Text = "Connected" } }
            //    }
            //};
        }        
    }
}
