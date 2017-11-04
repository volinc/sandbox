using Microsoft.AspNet.SignalR;
using System;
using System.Web.Http;

namespace SignalR.Server
{
    public class OffersController : ApiController
    {
        private readonly IHubContext<INotificationHub> hubContext;

        public OffersController(IHubContext<INotificationHub> hubContext)
        {
            this.hubContext = hubContext;
        }

        public void Post()
        {
            var offer = new Offer
            {
                Id = Guid.NewGuid().ToString("N")
            };
            
            hubContext.Clients.All.NewOffer(offer);
        }
    }
}
