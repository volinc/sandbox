using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Forms.Driving.Data;
using Newtonsoft.Json;

namespace Forms.Driving.Infrastructure
{
    public abstract class ServiceClient
    {
        public const string JsonMediaType = "application/json";
        
        protected ServiceClientConfiguration Configuration { get; }

        protected Uri BaseUri { get; }
        protected TimeSpan Timeout { get; } 
        protected TimeSpan SpecTimeout { get; }
        protected TokenStore TokenStore { get; }
        protected HttpClient HttpClient { get; set; }

        private readonly IConnectivityService connectivityService;        
        private readonly TaskQueue requestQueue;

        public virtual event EventHandler LoggedIn;
        public virtual event EventHandler LoggedOut;

        private bool isLoggedIn;
        public virtual bool IsLoggedIn
        {
            get => isLoggedIn;
            protected set
            {
                if (value == isLoggedIn) return;
                isLoggedIn = value;

                if (isLoggedIn)
                    LoggedIn?.Invoke(this, EventArgs.Empty);
                else
                    LoggedOut?.Invoke(this, EventArgs.Empty);
            }
        }

        protected ServiceClient(ServiceClientConfiguration configuration, HttpMessageHandler authMessageHandler,
                                TokenStore tokenStore, IConnectivityService connectivityService, TaskQueue requestQueue)
        {
            Configuration = configuration;
            TokenStore = tokenStore;
            this.connectivityService = connectivityService;            
            this.requestQueue = requestQueue;

            ////mono workaround...
            //ServicePointManager.DnsRefreshTimeout = 0;

            BaseUri = Configuration.BaseUri;
            Timeout = Configuration.Timeout ?? TimeSpan.FromSeconds(30);
            SpecTimeout = Configuration.SpecTimeout ?? TimeSpan.FromSeconds(90);
            HttpClient = CreateClient(BaseUri, Timeout, authMessageHandler);
        }

        public async Task ForceLogoutAsync(bool automatic = true, CancellationToken cancellationToken = default(CancellationToken))
        {
            if (automatic)
            {
                if (!connectivityService.IsConnected)
                    return;

                var isServerReachable = await connectivityService.IsServerReachableAsync();
                if (!isServerReachable)
                    return;
            }

            TokenStore.Clean();
            IsLoggedIn = false;
        }

        #region Helpers

        protected static HttpClient CreateClient(Uri baseAddress, TimeSpan timeout, HttpMessageHandler handler = null)
        {
            return new HttpClient(handler ?? new HttpClientHandler(), true)
            {
                BaseAddress = baseAddress,
                Timeout = timeout,
                DefaultRequestHeaders = { AcceptLanguage = { new StringWithQualityHeaderValue("ru-RU") } }
            };
        }

        protected static StringContent BuildContent(object value)
        {
            if (value == null)
                return null;

            var json = JsonConvert.SerializeObject(value);            
            
            return new StringContent(json, Encoding.UTF8, JsonMediaType);
        }

        #endregion

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        private static InvalidOperationException BadConnection(Exception webException)
            => new InvalidOperationException("Плохое соединение, попробуйте повторить действие позже.", webException);

        private async Task<HttpResponseMessage> SendAsync(HttpMessageInvoker httpClient, HttpStatusCode[] acceptableStatuses,
                                                          HttpRequestMessage requestMessage, CancellationToken cancellationToken)
        {
            var responseMessage = await httpClient.SendAsync(requestMessage, cancellationToken);

            return await HandleNotSuccessHttpStatusCodeAsync(responseMessage, acceptableStatuses, cancellationToken);
        }

        protected virtual async Task<HttpResponseMessage> SendAsync(HttpClient httpClient, HttpMethod method,
                                                                    string relativeUri, object value = null,
                                                                    CancellationToken? cancellationToken = null,
                                                                    HttpStatusCode[] acceptableStatuses = null)
        {
            var cancellation = cancellationToken ?? default(CancellationToken);

            return await requestQueue.Enqueue(
                () => SendWorkaroundAsync(httpClient, method, relativeUri, value, acceptableStatuses, cancellation));
        }

        private async Task<HttpResponseMessage> SendWorkaroundAsync(HttpMessageInvoker httpClient, HttpMethod method,
                                                                    string relativeUri, object value,
                                                                    HttpStatusCode[] acceptableStatuses,
                                                                    CancellationToken cancellationToken)
        {
            for (var i = 2; i >= 0; --i)
            {
                try
                {
                    var requestMessage = new HttpRequestMessage(method, relativeUri)
                    {
                        Content = BuildContent(value),
                        Headers = {{"Accept-Language", "ru-RU"}}
                    };

                    return await SendAsync(httpClient, acceptableStatuses, requestMessage, cancellationToken);
                }
                catch (HttpRequestException httpRequestException)
                {
                    throw BadConnection(httpRequestException);
                }
                catch (TimeoutException timeoutException)
                {
                    throw BadConnection(timeoutException);
                }
                catch (WebException webException)
                {
                    var conditional = TryHandleWebExceptionAsync(webException);
                    if (i != 0) continue;

                    if (conditional.HasValue)
                        throw conditional.Value;
                }
            }

            throw BadConnection(null);
        }

        protected virtual ConditionalValue<Exception> TryHandleWebExceptionAsync(WebException webException)
        {
            if (!connectivityService.IsConnected)
                throw new InvalidOperationException("Нет соединения с Интернетом.", webException);
            
            if (!connectivityService.IsServerReachableAsync().Result)
                throw new InvalidOperationException("Нет соединения с сервером.", webException);
            
            if (webException.Status == WebExceptionStatus.Timeout)
                throw new InvalidOperationException("Сервер не доступен.");

            var exception = BadConnection(webException);
            
            return new ConditionalValue<Exception>(exception);
        }

        protected virtual async Task<HttpResponseMessage> GetAsync(string relativeUri,
            CancellationToken? cancellationToken = null, HttpStatusCode[] acceptableStatuses = null)
        {
            return await SendAsync(HttpClient, HttpMethod.Get, relativeUri, null, cancellationToken, acceptableStatuses);
        }

        protected virtual async Task<HttpResponseMessage> PutAsync(string relativeUri, object value = null,
            CancellationToken? cancellationToken = null, HttpStatusCode[] acceptableStatuses = null)
        {
            return await SendAsync(HttpClient, HttpMethod.Put, relativeUri, value, cancellationToken, acceptableStatuses);
        }

        protected virtual async Task<HttpResponseMessage> PostAsync(string relativeUri, object value = null,
            CancellationToken? cancellationToken = null, HttpStatusCode[] acceptableStatuses = null)
        {
            return await SendAsync(HttpClient, HttpMethod.Post, relativeUri, value, cancellationToken, acceptableStatuses);
        }

        protected virtual async Task<HttpResponseMessage> DeleteAsync(string relativeUri,
            CancellationToken? cancellationToken, HttpStatusCode[] acceptableStatuses = null)
        {
            return await SendAsync(HttpClient, HttpMethod.Delete, relativeUri, null, cancellationToken, acceptableStatuses);
        }

        protected virtual async Task<HttpResponseMessage> HandleNotSuccessHttpStatusCodeAsync(
            HttpResponseMessage responseMessage, HttpStatusCode[] acceptableStatuses,
            CancellationToken cancellationToken)
        {
            var hasAcceptableStatuses = acceptableStatuses?.Contains(responseMessage.StatusCode);
            if (responseMessage.IsSuccessStatusCode || hasAcceptableStatuses.HasValue && hasAcceptableStatuses.Value)
                return responseMessage;

            switch (responseMessage.StatusCode)
            {
                case HttpStatusCode.Unauthorized:
                    await ForceLogoutAsync(true, cancellationToken);
                    break;
                case HttpStatusCode.Forbidden:
                    if (responseMessage.ReasonPhrase.Equals("Site Disabled", StringComparison.OrdinalIgnoreCase))
                        ThrowServerIsNotAvailable();

                    await HandleExpectedErrorContentAsync(responseMessage);
                    break;
                case HttpStatusCode.InternalServerError:
                    ThrowServerIsNotAvailable();
                    break;
                default:
                    await HandleExpectedErrorContentAsync(responseMessage);
                    break;
            }

            return responseMessage;
        }

        // Server is not available at this moment.
        private static void ThrowServerIsNotAvailable() => 
            throw new InvalidOperationException("В настоящий момент сервис недоступен.");

        private static async Task HandleExpectedErrorContentAsync(HttpResponseMessage responseMessage)
        {            
            var stringContent = await responseMessage.Content.ReadAsStringAsync();
            if (string.IsNullOrWhiteSpace(stringContent))
            {
                // There are breaking changes in server API.
                throw new InvalidOperationException("Проводятся технические работы. Приносим свои извинения за причиненное неудобство.");
            }

            var content = JsonConvert.DeserializeObject<HttpErrorResponseContentData>(stringContent);
            throw new ErrorResponseException(content);
        }
    }
}
