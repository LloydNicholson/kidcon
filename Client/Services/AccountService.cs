using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Services
{
    public class AccountService : IAccountService
    {
        public readonly IHttpService _httpService;
        private string url = "v1/account";

        public AccountService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<Account>> GetRandomAccounts()
        {
            var response = await _httpService.Get<List<Account>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(response.HttpResponseMessage.Content.ToString());
            }

            return response.Response;
        }
    }
}
