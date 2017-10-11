using System.Threading.Tasks;

namespace Forms.Infrastructure
{
    public interface IPermissionsManager
    {
        Task CheckPermissionsAsync();
    }
}