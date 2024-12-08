namespace KidCon.WebApp.Services;

using System.Collections.Generic;
using System.Threading.Tasks;
using KidCon.Database.Entities;
using Microsoft.EntityFrameworkCore;

public class AccountService(IDbContextFactory<KidConDbContext> factory)
{
    public async Task<List<Account>> SeedAccounts(List<ReceivedAccount> accounts)
    {
        await using var dbContext = await factory.CreateDbContextAsync();
        var existingAccounts = await dbContext.Accounts
            .AsNoTracking()
            .ToListAsync();

        var classifications = await dbContext.Classifications
            .AsNoTracking()
            .ToListAsync();

        foreach (var acc in accounts)
        {
            var accountExists = existingAccounts
                .Any(a => string.Equals(a.Name, acc.name, StringComparison.OrdinalIgnoreCase));

            if (!accountExists)
            {
                var classification = classifications
                    .FirstOrDefault(c => string.Equals(c.Type, acc.type, StringComparison.OrdinalIgnoreCase));

                var account = new Account
                {
                    IncreasingSide = acc.increasingSide,
                    Name = acc.name
                };

                var altsToAdd = new List<Alternative>();

                foreach (var alt in acc.alts)
                {
                    var alternative = new Alternative
                    {
                        AlternativeName = alt,
                        Account = account
                    };

                    altsToAdd.Add(alternative);
                }

                dbContext.Alternatives.AddRange(altsToAdd);
                dbContext.Accounts.Add(account);

                await dbContext.SaveChangesAsync();

                account.Classification = classification;
            }
        }

        await dbContext.SaveChangesAsync();

        return existingAccounts;
    }

    public async Task<List<Account>> GetRandomAccounts()
    {
        await using var dbContext = await factory.CreateDbContextAsync();
        var existingAccounts = await dbContext.Accounts
            .AsNoTracking()
            .Include(a => a.Classification)
            .Include(a => a.Alternatives)
            .ToListAsync();

        var accounts = new List<Account>();

        while (accounts.Count < 10)
        {
            var randomAccount = existingAccounts[Helpers.Helpers.GetRandomNumber(existingAccounts.Count)];
            accounts.Add(randomAccount);

            accounts = accounts.Distinct().ToList();
        }

        return accounts;
    }

    public async Task<List<Alternative>> GetAlternatives()
    {
        await using var dbContext = await factory.CreateDbContextAsync();
        var alts = await dbContext.Alternatives
            .AsNoTracking()
            .Include(a => a.Account)
            .ToListAsync();

        return alts;
    }
}