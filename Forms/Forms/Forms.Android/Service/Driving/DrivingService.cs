using System;
using System.Net.Http;
using System.Threading;
using Autofac;
using Forms.Driving;
using Forms.Driving.Infrastructure;
using Forms.Services;

namespace Forms.Droid.Service.Driving
{
    internal class DrivingService : IDrivingService
    {
        public event EventHandler<string> Received;

        public event EventHandler Started;

        public event EventHandler Stoped;

        public bool IsStarted { get; private set; }

        private readonly IContainer _container;

        private readonly CancellationTokenSource _cancellation;

        public DrivingService()
        {
            _container = BuildContainer(new EmulatorConfig());
            _cancellation = new CancellationTokenSource();
        }

        public void Start()
        {
            if (IsStarted) return;

            var driverEmulator = _container.Resolve<DriverEmulator>();            
            driverEmulator.StartAsync(_cancellation.Token).ConfigureAwait(false).GetAwaiter();

            IsStarted = true;
            Started?.Invoke(this, EventArgs.Empty);
        }

        public void Stop()
        {
            if (!IsStarted) return;

            _cancellation.Cancel();

            IsStarted = false;
            Stoped?.Invoke(this, EventArgs.Empty);
        }

        private static IContainer BuildContainer(EmulatorConfig config)
        {
            var builder = new ContainerBuilder();
            builder.RegisterInstance(config);
            builder.RegisterInstance(new ServiceClientConfiguration
            {
                ApiAuthority = config.ApiAuthority,
            });

            builder.RegisterType<NotificationEmulatorClient>().SingleInstance();
            builder.RegisterType<DriverEmulator>().SingleInstance();
            builder.RegisterType<Settings>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<TokenStore>().SingleInstance();
            builder.RegisterType<OAuthMessageHandler>().As<HttpMessageHandler>().SingleInstance();
            builder.RegisterType<ConnectivityService>().AsImplementedInterfaces().SingleInstance();            
            builder.RegisterType<Logger>().AsImplementedInterfaces().SingleInstance();
            builder.RegisterType<DriverClient>().SingleInstance();
            builder.RegisterType<SignalRClient>().SingleInstance();
            return builder.Build();
        }
    }
}