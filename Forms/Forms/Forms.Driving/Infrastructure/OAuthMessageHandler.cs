
using System;
using System.Diagnostics;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Forms.Driving.Data;
using Newtonsoft.Json;

namespace Forms.Driving.Infrastructure
{
    public class OAuthMessageHandler : DelegatingHandler
    {
        private readonly ServiceClientConfiguration configuration;        
        private readonly TokenStore tokenStore;
        private TokenResponse lastTokenResponse;

        public OAuthMessageHandler(ServiceClientConfiguration configuration, TokenStore tokenStore) : base(new HttpClientHandler())
        {
            this.configuration = configuration;
            this.tokenStore = tokenStore;            
        }

        private async Task<TokenResponse> TryRefreshTokensAsync(CancellationToken cancellationToken)
        {
            try
            {
                var refreshToken = lastTokenResponse?.RefreshToken;
                if (string.IsNullOrWhiteSpace(refreshToken))
                    return null;

                var tokenRequest = new HttpRequestMessage(HttpMethod.Put, configuration.TokensUri);
                var json = JsonConvert.SerializeObject(new
                {
                    grant_type = "refresh_token",
                    refresh_token = refreshToken
                });
                tokenRequest.Content = new StringContent(json, Encoding.UTF8, ServiceClient.JsonMediaType);
                
                var response = await base.SendAsync(tokenRequest, cancellationToken);
                if (!response.IsSuccessStatusCode)
                    return null;

                var jsonContent = await response.Content.ReadAsStringAsync();
                var content = JsonConvert.DeserializeObject<TokenResponse>(jsonContent);

                return content;
            }
            catch (Exception exception)
            {
                Debug.WriteLine(exception.Message);
                return lastTokenResponse;
            }
        }

        private static void SetAuthorizationHeader(HttpRequestMessage request, string accessToken)
        {
            request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (cancellationToken == CancellationToken.None)
                cancellationToken = new CancellationTokenSource(TimeSpan.FromSeconds(60)).Token;

            lastTokenResponse = tokenStore.Get();
            if (lastTokenResponse == default(TokenResponse))
                return new HttpResponseMessage(HttpStatusCode.Unauthorized);

            var accessToken = lastTokenResponse?.AccessToken;
            SetAuthorizationHeader(request, accessToken);
            var response = await base.SendAsync(request, cancellationToken);

            if (response.StatusCode != HttpStatusCode.Unauthorized)
                return response;

            lastTokenResponse = await tokenStore.UpdateAsync(TryRefreshTokensAsync, cancellationToken);
            if (lastTokenResponse == default(TokenResponse))
                return response;

            accessToken = lastTokenResponse?.AccessToken;
            SetAuthorizationHeader(request, accessToken);
            return await base.SendAsync(request, cancellationToken);
        }
    }
}
