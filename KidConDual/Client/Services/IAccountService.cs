using System.Threading.Tasks;
using Kidcon.Shared.Models;

namespace KidConDual.Client.Services
{
    public interface IAccountService
    {
        Task<Account> GetRandomAccount();
    }
}