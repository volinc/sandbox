using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading;
using System.Threading.Tasks;

namespace SignalR.Client
{
    // https://docs.microsoft.com/en-us/aspnet/web-api/overview/advanced/httpclient-message-handlers
    public class OAuthMessageHandler : DelegatingHandler
    {
        private readonly TokenStore _tokenStore;        
        
        public OAuthMessageHandler(TokenStore tokenStore, HttpMessageHandler innerHandler) : base(innerHandler)
        {        
            _tokenStore = tokenStore;            
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _tokenStore.AccessToken);

            return await base.SendAsync(request, cancellationToken).ConfigureAwait(false);
        }
    }
}
