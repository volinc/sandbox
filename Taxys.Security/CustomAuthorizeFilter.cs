namespace Taxys.Security
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Authorization.Policy;
    using Microsoft.AspNetCore.Mvc.Authorization;
    using Microsoft.AspNetCore.Mvc.Filters;
    using Microsoft.Extensions.DependencyInjection;
    using Taxys.Security.Models;

    // см. https://ignas.me/tech/custom-unauthorized-response-body/        
    public class CustomAuthorizeFilter : IAsyncAuthorizationFilter
    {
        public AuthorizationPolicy Policy { get; }

        public CustomAuthorizeFilter(AuthorizationPolicy policy)
        {
            Policy = policy ?? throw new ArgumentNullException(nameof(policy));
        }

        public async Task OnAuthorizationAsync(AuthorizationFilterContext context)
        {
            if (context == null)
                throw new ArgumentNullException(nameof(context));

            var hasAnonymousAttribute = context.Filters.Any(item => item is IAllowAnonymousFilter);

            if (hasAnonymousAttribute)
                return;

            var policyEvaluator = context.HttpContext.RequestServices.GetRequiredService<IPolicyEvaluator>();
            var authenticateResult = await policyEvaluator.AuthenticateAsync(Policy, context.HttpContext);
            var authorizeResult = await policyEvaluator.AuthorizeAsync(Policy, authenticateResult, context.HttpContext, context);

            if (authorizeResult.Challenged)
                Set401HttpStatus(context);
            else if (authorizeResult.Forbidden)
                Set403HttpStatus(context);
        }

        private static void Set403HttpStatus(AuthorizationFilterContext context)
        {
            context.Result = new ForbidResult("Resource access is forbidden.");
        }

        private static void Set401HttpStatus(AuthorizationFilterContext context)
        {
            context.Result = new UnauthorizedResult("Authorization has been denied for this request.");
        }
    }
}
