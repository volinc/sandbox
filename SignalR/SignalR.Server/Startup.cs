using Autofac;
using Autofac.Integration.SignalR;
using Autofac.Integration.WebApi;
using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Infrastructure;
using Microsoft.Owin.Cors;
using Owin;
using SignalR.Server.SignalR;
using System.Reflection;
using System.Web.Http;
using Swashbuckle.Application;

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
            builder.RegisterType<UserIdProvider>().As<IUserIdProvider>().SingleInstance();
            builder.RegisterType<NotificationSender>().SingleInstance();
            builder.Register(i => hubConfiguration.Resolver.Resolve<IConnectionManager>().GetHubContext<NotificationHub, INotificationHubProxy>()).ExternallyOwned();
            builder.RegisterType<CustomAuthMiddleware>().SingleInstance();
            var container = builder.Build();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(container);
            config
                .EnableSwagger(c => c.SingleApiVersion("v1", "SignalR server test API"))
                .EnableSwaggerUi();

            hubConfiguration.Resolver = new AutofacDependencyResolver(container);
            hubConfiguration.EnableDetailedErrors = true;
            hubConfiguration.EnableJavaScriptProxies = true;
            hubConfiguration.EnableJSONP = false;

            appBuilder.UseAutofacWebApi(config);
            appBuilder.UseAutofacMiddleware(container);
            appBuilder.UseCors(CorsOptions.AllowAll);
            appBuilder.UseWebApi(config);            
            appBuilder.MapSignalR(hubConfiguration);            
        }
    }
}
