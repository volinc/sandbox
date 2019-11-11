namespace Taxys.Security
{
    using System;
    using System.Net.Http.Headers;
    using System.Security.Claims;
    using System.Text.Encodings.Web;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Authentication;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;
    using Microsoft.Net.Http.Headers;
    using Taxys.Domain;

    // см. https://ignas.me/tech/custom-authentication-asp-net-core-20/
    public class CustomAuthHandler : AuthenticationHandler<CustomJwtBearerOptions>
    {        
        private readonly AuthenticationService authenticationService;

        public CustomAuthHandler(AuthenticationService authenticationService,
                                 IOptionsMonitor<CustomJwtBearerOptions> options, ILoggerFactory logger,
                                 UrlEncoder encoder, ISystemClock clock) : base(options, logger, encoder, clock)
        {
            this.authenticationService = authenticationService;
        }

        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {                   
            if (!Request.Headers.TryGetValue(HeaderNames.Authorization, out var authorization))
            {
                if (Request.Query.TryGetValue("access_token", out var token))
                    authorization = token;
                else
                    return AuthenticateResult.NoResult();
            }
                        
            var optionalPrincipal = await TryGetPrincipalAsync(authorization);
            if (!optionalPrincipal.TryGet(out var principal))
                return AuthenticateResult.Fail("Unable to resolve principal.");
            
            var ticket = new AuthenticationTicket(principal, Options.Scheme);

            return AuthenticateResult.Success(ticket);
        }

        private async Task<ConditionalValue<ClaimsPrincipal>> TryGetPrincipalAsync(string authorizationHeader)
        {
            if (!TryGetToken(authorizationHeader, Options.Scheme, out var token))
                return ConditionalValue<ClaimsPrincipal>.None;

            if (!authenticationService.TryDecryptAccessPayload(token, out var accessPayload))
                return ConditionalValue<ClaimsPrincipal>.None;

            if (!await authenticationService.IsAccessPayloadStoredAsync(accessPayload))
                return ConditionalValue<ClaimsPrincipal>.None;

            var principal = accessPayload.ToPrincipal();
            return new ConditionalValue<ClaimsPrincipal>(principal);
        }
        
        private static bool TryGetToken(string authorizationHeader, string authenticationScheme, out string token)
        {
            token = null;

            if (!AuthenticationHeaderValue.TryParse(authorizationHeader, out var authentication)) 
                return false;

            if (!authenticationScheme.Equals(authentication.Scheme, StringComparison.OrdinalIgnoreCase))
                return false;

            token = authentication.Parameter;

            return true;
        }

        protected override Task HandleForbiddenAsync(AuthenticationProperties properties)
        {
            return base.HandleForbiddenAsync(properties);
        }
    }
}
