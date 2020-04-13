using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using ClientApp.Server.Data;
using ClientApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace ClientApp.Server.Controllers.v1
{
    [ApiController]
    [Route("v1/account")]
    public class AccountController : ControllerBase
    {
        private readonly KidConDbContext _dbContext;

        public AccountController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> SeedAccounts([FromBody] List<ReceivedAccount> accounts)
        {
            using var dbContext = OpenDbContext();
            var existingAccounts = await dbContext.Accounts.AsNoTracking()
                .ToListAsync();

            var classifications = await dbContext.Classifications.AsNoTracking()
                .ToListAsync();

            foreach (var acc in accounts)
            {
                var accountExists = existingAccounts.Any(
                    a => string.Equals(a.Name, acc.name, StringComparison.OrdinalIgnoreCase)
                );

                if (!accountExists)
                {
                    var classification = classifications.FirstOrDefault(c => string.Equals(c.Type, acc.type, StringComparison.OrdinalIgnoreCase));

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

                    dbContext.SaveChanges();

                    account.Classification = classification;
                }
            }
            await dbContext.SaveChangesAsync();

            return Ok(existingAccounts);
        }

        [HttpGet]
        public IActionResult GetRandomAccounts()
        {
            using var dbContext = OpenDbContext();

            var existingAccounts = dbContext.Accounts.AsNoTracking()
                .Include(a => a.Classification)
                .Include(a => a.Alternatives)
                .ToArray();

            var accounts = new List<Account>();

            while (accounts.Count < 10)
            {
                var randomAccount = existingAccounts[Helpers.Helpers.GetRandomNumber(existingAccounts.Length)];
                accounts.Add(randomAccount);

                accounts = accounts.Distinct().ToList();
            }

            return Ok(accounts);
        }

        [HttpGet]
        [Route("alternatives")]
        public IActionResult GetAlternatives()
        {
            using var dbContext = OpenDbContext();

            var alts = dbContext.Alternatives.AsNoTracking()
                .Include(a => a.Account)
                .ToArray();

            return Ok(alts);
        }

        private KidConDbContext OpenDbContext()
        {
            return _dbContext ?? new KidConDbContext();
        }
    }
}
