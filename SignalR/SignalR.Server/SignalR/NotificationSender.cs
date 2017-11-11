using Microsoft.AspNet.SignalR;
using System.Threading.Tasks;

namespace SignalR.Server.SignalR
{
    public class NotificationSender
    {
        private readonly IHubContext<INotificationHubProxy> hubContext;

        public NotificationSender(IHubContext<INotificationHubProxy> hubContext)
        {
            this.hubContext = hubContext;
        }

        public Task SendNewOfferAsync(string userName, Offer offer)
        {
            return Task.Run(() =>
            {
                hubContext.Clients.User(userName).NewOffer(offer);
            });            
        }
    }
}
