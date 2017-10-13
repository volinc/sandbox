using System.Net.Http;
using System.Threading.Tasks;
using Forms.Driving.Data;

namespace Forms.Driving
{
    public class NotificationEmulatorClient
    {
        private readonly HttpClient client;

        public NotificationEmulatorClient(EmulatorConfig config)
        {
#if STAGE
#elif RELEASE
#else
            client = new HttpClient
            {
                BaseAddress = new Uri($"{config.ApiAuthorityEmulator}/api/v1/", UriKind.RelativeOrAbsolute)
            };
#endif            
        }

        public async Task<ConditionalValue<string>> TryGetConfirmationCodeAsync(string phone)
        {       
#if STAGE
            return await Task.FromResult(ConditionalValue<string>.None);
#elif RELEASE
            return await Task.FromResult(ConditionalValue<string>.None);
#else
            try
            {
                var jsonContent = await client.GetStringAsync($"notifications/last?type=Sms&clientCode={phone.Trim()}");
                var content = JsonConvert.DeserializeObject(jsonContent) as JObject;
                var jsonData = content?.Property("JsonData").Value.ToString();
                var data = JsonConvert.DeserializeObject(jsonData) as JObject;
                var result = data?.Property("Code").Value.ToString();

                return result == null ? ConditionalValue<string>.None : new ConditionalValue<string>(result);
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
                return ConditionalValue<string>.None;
            }
#endif
        }
    }
}
