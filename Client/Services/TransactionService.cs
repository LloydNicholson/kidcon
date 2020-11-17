using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Client.Interfaces;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Services
{
    public class TransactionService : ITransactionService
    {
        public readonly IHttpService _httpService;
        private string url = "v1/transaction";

        public TransactionService(IHttpService httpService)
        {
            _httpService = httpService;
        }

        public async Task<List<Sentence>> GetSentences(int length)
        {
            var uri = $"{url}/sentence/{length}";

            var response = await _httpService.Get<List<Sentence>>(uri);

            if (!response.Success)
            {
                throw new ApplicationException(response.HttpResponseMessage.Content.ToString());
            }

            return response.Response;
        }
    }
}
