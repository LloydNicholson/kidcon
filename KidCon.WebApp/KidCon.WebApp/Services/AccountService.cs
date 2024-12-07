namespace KidCon.WebApp.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Shared.Models;

public class AccountService(HttpService httpService) : IAccountService
{
    private const string Url = "v1/account";

    public async Task<List<Account>> GetRandomAccounts()
    {
        var res = await httpService.Get<List<Account>>(Url);
        if (!res.Success)
        {
            throw new ApplicationException(res.HttpResponseMessage.Content.ToString());
        }

        return res.Response;
    }
}