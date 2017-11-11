using Microsoft.Owin;
using System;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;

namespace SignalR.Server
{    
    public class CustomAuthMiddleware : OwinMiddleware
    {
        public CustomAuthMiddleware(OwinMiddleware next) : base(next)
        {
        }

        public override async Task Invoke(IOwinContext context)
        {
            if (context.Request.Headers.TryGetValue("Authorization", out var values))
            {
                var value = values.SingleOrDefault();
                var userName = value.Split(new[] { " " }, 1, StringSplitOptions.RemoveEmptyEntries).LastOrDefault();
            
                var identity = new GenericIdentity(userName);
                context.Request.User = new GenericPrincipal(identity, null);
            }

            await Next.Invoke(context);
        }
    }
}
