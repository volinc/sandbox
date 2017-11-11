using SignalR.Server.SignalR;
using System;
using System.Threading.Tasks;
using System.Web.Http;

namespace SignalR.Server
{
    [Authorize]    
    public class OffersController : ApiController
    {
        private readonly NotificationSender notificationSender;

        public OffersController(NotificationSender notificationSender)
        {
            this.notificationSender = notificationSender;
        }

        [HttpGet]        
        public Task<Offer> GetAsync()
        {
            return Task.FromResult(new Offer
            {
                Id = Guid.NewGuid().ToString("N")
            });
        }

        [HttpPost]        
        public async Task PostAsync()
        {
            var offer = new Offer
            {
                Id = Guid.NewGuid().ToString("N")
            };            

            await notificationSender.SendNewOfferAsync(User.Identity.Name, offer);
        }
    }
}
