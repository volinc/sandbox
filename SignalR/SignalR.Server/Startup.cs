using Autofac;
using Autofac.Integration.SignalR;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
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
            var config = new HttpConfiguration();
            var hubConfiguration = new HubConfiguration();

            var builder = new ContainerBuilder();
            builder.RegisterApiControllers(Assembly.GetExecutingAssembly());
            builder.RegisterHubs(Assembly.GetExecutingAssembly());
            builder.Register(i => hubConfiguration.Resolver.Resolve<IConnectionManager>().GetHubContext<NotificationHub, INotificationHub>()).ExternallyOwned();
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            hubConfiguration.Resolver = new AutofacDependencyResolver(container);

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            hubConfiguration.EnableDetailedErrors = true;
            hubConfiguration.EnableJavaScriptProxies = true;
            hubConfiguration.EnableJSONP = true;                       

            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseAutofacWebApi(config);
            appBuilder.UseWebApi(config);
            appBuilder.UseCors(CorsOptions.AllowAll);                       
            appBuilder.MapSignalR(hubConfiguration);                        
        }
    }
}
