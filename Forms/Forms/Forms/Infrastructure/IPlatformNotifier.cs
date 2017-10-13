using System.Threading.Tasks;

namespace Forms.Infrastructure
{
    public interface IPlatformNotifier
    {
        Task<bool> ShowDialogAsync(string message);
    }
}