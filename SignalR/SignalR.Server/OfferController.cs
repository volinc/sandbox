using System;
using System.Web.Http;

namespace SignalR.Server
{
    public class OfferController : ApiController
    {
        private readonly NotificationHub notificationHub;

        public OfferController(NotificationHub notificationHub)
        {
            this.notificationHub = notificationHub;
        }

        public void PostOffer()
        {
            var offer = new Offer
            {
                Id = Guid.NewGuid().ToString("N")
            };

            notificationHub.SendNewOffer(offer);
        }
    }
}
