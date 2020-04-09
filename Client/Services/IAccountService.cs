using System.Threading.Tasks;
using Kidcon.Shared.Models;

namespace Kidcon.Client.Services
{
    public interface IAccountService
    {
        Task<Account> GetRandomAccount();
    }
}