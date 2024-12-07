using System.Threading.Tasks;

namespace ClientApp.Client.Services
{
    public interface IEquationService
    {
        Task<string> GetRandomName();
    }
}