using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Forms.Driving.Infrastructure
{
    public static class HttpResponseMessageExtensions
    {
        public static async Task<TResult> GetContentAsync<TResult>(this Task<HttpResponseMessage> responseTask)
        {
            var response = await responseTask;
            var stringContent = await response.Content.ReadAsStringAsync().ConfigureAwait(false);
            return JsonConvert.DeserializeObject<TResult>(stringContent);
        }
    }
}
