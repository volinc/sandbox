using Microsoft.Owin.Hosting;
using System;

namespace SignalR.Server
{
    internal class Program
    {
        // https://docs.microsoft.com/en-us/aspnet/web-api/overview/hosting-aspnet-web-api/use-owin-to-self-host-web-api
        // https://docs.microsoft.com/en-us/aspnet/signalr/overview/deployment/tutorial-signalr-self-host
        private static void Main(string[] args)
        {
            const string url = "http://localhost:9000/";
            
            using (WebApp.Start<Startup>(url))
            {
                Console.WriteLine("Server running on {0}", url);
                Console.ReadLine();                
            }
        }
    }
}
