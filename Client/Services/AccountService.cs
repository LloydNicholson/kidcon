using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Services
{
    public class AccountService : IAccountService
    {
        public readonly HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Account>> GetRandomAccounts()
        {
            return await _httpClient.GetFromJsonAsync<List<Account>>("v1/account");
        }
    }
}
