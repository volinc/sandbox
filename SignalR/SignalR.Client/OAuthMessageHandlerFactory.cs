using System.Net.Http;

namespace SignalR.Client
{
    public class OAuthMessageHandlerFactory
    {
        private readonly TokenStore _tokenStore;
        
        public OAuthMessageHandlerFactory(TokenStore tokenStore)
        {
            _tokenStore = tokenStore;            
        }

        public OAuthMessageHandler Create(HttpMessageHandler innerHandler)
        {
            return new OAuthMessageHandler(_tokenStore, innerHandler);
        }
    }
}
