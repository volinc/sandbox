using Microsoft.AspNet.SignalR;
using System;
using System.Web.Http;

namespace SignalR.Server
{
    public class OffersController : ApiController
    {
        private readonly IHubContext<IHubClient> hubContext;

        public OffersController(IHubContext<IHubClient> hubContext)
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
