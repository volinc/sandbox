using Autofac;
using Autofac.Integration.SignalR;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.SignalR;
using Microsoft.Owin.Cors;
using Owin;
using System.Reflection;
using System.Web.Http;

namespace SignalR.Server
{
    public class Startup
    {
        public void Configuration(IAppBuilder appBuilder)
        {
            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterHubs(Assembly.GetExecutingAssembly());
            var container = builder.Build();

            var config = new HttpConfiguration
            {
                DependencyResolver = new AutofacWebApiDependencyResolver(container)
            };

            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseAutofacWebApi(config);
            appBuilder.UseWebApi(config);

            appBuilder.UseCors(CorsOptions.AllowAll);

            var hubConfiguration = new HubConfiguration
            {
                EnableDetailedErrors = true,
                EnableJavaScriptProxies = true,
                EnableJSONP = true,
                Resolver = new AutofacDependencyResolver(container)
            };

            appBuilder.MapSignalR(hubConfiguration);                        
        }
    }
}
