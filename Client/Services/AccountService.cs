using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using Kidcon.Shared.Models;

namespace Kidcon.Client.Services
{
    public class AccountService : IAccountService
    {
        public readonly HttpClient _httpClient;

        public AccountService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<Account> GetRandomAccount()
        {
            var res = await _httpClient.GetStreamAsync("v1/account");

            return await JsonSerializer.DeserializeAsync<Account>
                (res, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
        }
    }
}
