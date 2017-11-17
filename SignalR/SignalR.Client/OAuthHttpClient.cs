using System.Net.Http;
using Microsoft.AspNet.SignalR.Client.Http;

namespace SignalR.Client
{
    public class OAuthHttpClient : DefaultHttpClient
    {
        private readonly OAuthMessageHandlerFactory _authMessageHandlerFactory;

        public OAuthHttpClient(OAuthMessageHandlerFactory authMessageHandlerFactory)
        {
            _authMessageHandlerFactory = authMessageHandlerFactory;
        }

        protected override HttpMessageHandler CreateHandler()
        {
            return _authMessageHandlerFactory.Create(base.CreateHandler());
        }
    }
}
