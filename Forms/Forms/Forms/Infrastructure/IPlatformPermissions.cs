using System.Threading.Tasks;

namespace Forms.Infrastructure
{
    public interface IPlatformPermissions
    {
        Task RequestLocationAsync();

        Task RequestSmsAsync();
    }
}