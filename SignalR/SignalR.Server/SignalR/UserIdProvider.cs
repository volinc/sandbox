using Microsoft.AspNet.SignalR;

namespace SignalR.Server.SignalR
{
    public class UserIdProvider : IUserIdProvider
    {
        public string GetUserId(IRequest request)
        {
            return request.User.Identity.Name;
        }
    }
}
