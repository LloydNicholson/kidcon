using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Server.Data;
using ClientApp.Server.Managers.Names;
using ClientApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientApp.Server.Managers.Accounts
{
    public static class AccountManager
    {
        public static async Task<List<Sentence>> GenerateSentences(KidConDbContext dbContext, int sentenceLength, BusinessType type)
        {
            var sentences = new List<Sentence>();
            // Get name of owner
            var owner = NameManager.GetRandomName(dbContext);
            var business = NameManager.GetRandomBusiness(dbContext);

            var businessName = $"{owner.FirstName}'s {business.Description}s";

            for (var i = 0; i < sentenceLength; i++)
            {
                // Get name of other party
                var otherParty = NameManager.GetRandomName(dbContext);

                if (owner.FirstName.Equals(otherParty.FirstName, StringComparison.OrdinalIgnoreCase))
                {
                    otherParty = NameManager.GetRandomName(dbContext);
                }

                // Get random account name
                var account = await GetRandomAccountAsync(dbContext);

                var sentence = new Sentence()
                {
                    BusinessName = businessName,
                    OtherParty = otherParty,
                    Business = business,
                    Owner = owner,
                    Account = account,
                    TransactionAmount = Helpers.Helpers.GetRandomNumber(100000)
                };

                var dualAccounts = new string[] { "Asset", "Liability" };
                var payAccounts = new string[] { "Expense" };
                var receiveAccounts = new string[] { "Income" };

                if (dualAccounts.Contains(sentence.Account.Classification.Type))
                {
                    sentence.Method = Helpers.Helpers.GetRandomNumber(2) == 1 ? Method.Paid : Method.Received;
                }

                if (payAccounts.Contains(sentence.Account.Classification.Type))
                {
                    sentence.Method = Method.Paid;
                }

                if (receiveAccounts.Contains(sentence.Account.Classification.Type))
                {
                    sentence.Method = Method.Received;
                }

                dbContext.Sentences.Add(sentence);

                sentences.Add(sentence);
            }

            return sentences;
        }

        public static async Task<Account> GetRandomAccountAsync(KidConDbContext dbContext)
        {
            var existingAccounts = await dbContext.Accounts.AsNoTracking()
                .Include(a => a.Classification)
                .Include(a => a.Alternatives)
                .ToArrayAsync();

            var randomAccount = existingAccounts[Helpers.Helpers.GetRandomNumber(existingAccounts.Length)];

            return randomAccount;
        }
    }
}
