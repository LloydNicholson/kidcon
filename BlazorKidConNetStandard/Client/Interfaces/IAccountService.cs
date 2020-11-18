using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Services
{
    public interface IAccountService
    {
        Task<List<Account>> GetRandomAccounts();
        Task<Account> GetRandomAccount();
    }
}