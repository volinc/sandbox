using System.Threading.Tasks;

namespace Forms.Driving.Infrastructure
{
    public interface IPlatformAppLauncher
    {
        Task<bool> TryLaunchAsync(string applicationName);
    }
}