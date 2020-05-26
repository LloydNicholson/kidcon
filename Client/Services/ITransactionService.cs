using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Services
{
    public interface ITransactionService
    {
        Task<List<Sentence>> GetSentences(int length);
    }
}
