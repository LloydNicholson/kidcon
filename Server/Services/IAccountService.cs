using System.Threading.Tasks;
using Kidcon.Shared.Models;

namespace Kidcon.Server.Services
{
    public interface IAccountService
    {
        Task<Account> GetRandomAccount();
    }
}