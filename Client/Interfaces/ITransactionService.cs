using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Shared.Contracts;
using ClientApp.Shared.Models;

namespace ClientApp.Client.Interfaces
{
    public interface ITransactionService
    {
        Task<List<Sentence>> GetSentences(int length);
    }
}
