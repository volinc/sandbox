using SignalR.Server.SignalR;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SignalR.Server
{    
    [RoutePrefix("api/v1")]
    public class OffersController : ApiController
    {
        private readonly NotificationSender _notificationSender;

        public OffersController(NotificationSender notificationSender)
        {
            this._notificationSender = notificationSender;
        }

        [HttpPost]      
        [Route("drivers/{driverId}/offers")]
        public async Task PostAsync(long driverId)
        {
            var offer = new Offer
            {
                Id = Guid.NewGuid().ToString("N")
            };

            var userName = $"driver-{driverId}";

            await _notificationSender.SendNewOfferAsync(userName, offer);
        }
    }
}
