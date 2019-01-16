using System.Threading.Tasks;

namespace packtWebapp.Services
{
    public interface ISeedDataService
    {
        Task EnsureSeedData();
    }
}