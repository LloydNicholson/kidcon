using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Client.Services;
using ClientApp.Shared.Models;
using MatBlazor;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Client.Pages.Transactions
{
    public class TransactionsBase : ComponentBase
    {
        [Inject]
        private ITransactionService transactionService { get; set; }

        public DateTime CurrentFormattedDate { get; set; }
        public string BusinessName { get; set; }

        public List<MatDataTableRow> TableItems;

        public TransactionsBase()
        {
        }

        public List<Sentence> sentences;

        protected override async Task OnInitializedAsync()
        {
            sentences = await transactionService.GetSentences(10);
            DefineTransactionDetails();
        }

        private void DefineTransactionDetails()
        {
            var date = DateTime.Now.ToLocalTime();

            BusinessName = sentences?[0]?.BusinessName ?? "";

            CurrentFormattedDate = date;
        }

        public string ScaffoldSentence(Sentence sentence)
        {
            var otherParty = $"{sentence.OtherParty.FirstName} {sentence.OtherParty.LastName}";

            var formatter = new NumberFormatInfo()
            {
                CurrencyGroupSeparator = " ",
                CurrencyDecimalDigits = 0,
                CurrencySymbol = "R"
            };

            var currencyValue = sentence.TransactionAmount.ToString("C", formatter);

            var method = sentence.Method == Method.Paid ?
            $"paid {otherParty} {currencyValue}" :
            $"received {currencyValue} from {otherParty}";

            var accountName = sentence.Account.Name;

            // Random alternative
            var random = new Random();
            var account = sentence.Account.Alternatives.Any() ?
            sentence.Account.Alternatives.ToArray()[random.Next(sentence.Account.Alternatives.Count() - 1)].AlternativeName :
            accountName;

            // Random business name or owner
            var randomBusiness = new Random().Next(2) == 1 ? sentence.BusinessName : "The business";
            var scaffoldedSentence = $"{randomBusiness} {method} for {account}";

            return scaffoldedSentence;
        }
    }
}
