using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using BlazorKidConApp.Client.Interfaces;
using BlazorKidConApp.Shared.Models;

namespace BlazorKidConApp.Client.Services
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
            var response = await _httpService.GetAsync<List<Account>>(url);
            if (!response.Success)
            {
                throw new ApplicationException(response.HttpResponseMessage.Content.ToString());
            }

            return response.Response;
        }

        public async Task<Account> GetRandomAccount()
        {
            var response = await _httpService.GetAsync<Account>($"{url}/single");
            if (!response.Success)
            {
                throw new ApplicationException(response.HttpResponseMessage.Content.ToString());
            }

            return response.Response;
        }
    }
}
