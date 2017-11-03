using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;
using System.Web.Http;

namespace SignalR.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var config = new HttpConfiguration();
            
            appBuilder.UseWebApi(config);

            appBuilder.UseCors(CorsOptions.AllowAll);

            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true,
                EnableJavaScriptProxies = true,
                EnableJSONP = true,
            };

            appBuilder.MapSignalR(hubConfiguration);                       
        }
    }
}
