using System;
using Autofac;
using Forms.Infrastructure;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Forms
{
    public partial class App : Application
    {
        private readonly IContainer container;
        private IRegistry registry;

        public App(AppSetup setup)
        {
            InitializeComponent();

            container = setup.CreateContainer();

            registry = container.Resolve<IRegistry>();
            registry.Connected += RegistryOnConnected;
            registry.Disconnected += RegistryOnDisconnected;

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
            MainPage = new ContentPage
            {
                Content = new StackLayout
                {
                    Children = { new Label { Text = "Connected" } }
                }
            };
        }
    }
}
