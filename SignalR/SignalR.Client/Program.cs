using System;
using Autofac;
using Newtonsoft.Json;
using System.Linq;

namespace SignalR.Client
{
    internal class Program
    {
        private static IContainer container;

        private static void Main()
        {
            container = BuildContainer();

            var signalRClient = container.Resolve<SignalRClient>();

            signalRClient.NewOffer += SignalRClientOnNewOffer;
            signalRClient.Start();

            Console.ReadLine();
        }

        private static void SignalRClientOnNewOffer(object sender, Offer offer)
        {
            var json = JsonConvert.SerializeObject(offer, Formatting.Indented);            
            Console.WriteLine($"###{Environment.NewLine}{json}{Environment.NewLine}###");

            var offerRepository = new OfferRepository();

            offerRepository.Create(offer);
            var offers = offerRepository.ReadAll();
            Console.WriteLine(string.Join(",", offers.Select(x => x.Id)));
        }

        private static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SignalRClient>().SingleInstance();
            builder.RegisterType<ConnectivityService>().SingleInstance();
            builder.RegisterType<ApiConfig>().SingleInstance();
            builder.RegisterType<TokenStore>().SingleInstance();

            return builder.Build();
        }
    }
}
