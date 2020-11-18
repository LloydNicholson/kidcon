using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorKidConApp.Shared.Models;

namespace BlazorKidConApp.Client.Interfaces
{
    public interface IAccountService
    {
        Task<List<Account>> GetRandomAccounts();
        Task<Account> GetRandomAccount();
    }
}