using System.Threading.Tasks;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Services
{
    public interface IAccountService
    {
        Task<Account> GetRandomAccount();
    }
}