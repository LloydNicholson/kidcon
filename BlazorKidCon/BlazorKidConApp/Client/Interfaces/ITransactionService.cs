using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorKidConApp.Shared.Models;

namespace BlazorKidConApp.Client.Interfaces
{
    public interface ITransactionService
    {
        Task<List<Sentence>> GetSentences(int length);
    }
}
