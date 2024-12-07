namespace KidCon.WebApp.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Shared.Models;

public interface IAccountService
{
    Task<List<Account>> GetRandomAccounts();
}