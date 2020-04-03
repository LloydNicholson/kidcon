using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using Kidcon.Shared.Models;
using Kidcon.WebApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kidcon.WebApi.Controllers.v1
{
    [Route("v1/account")]
    public class AccountController : Controller
    {
        private readonly KidConDbContext _dbContext;

        public AccountController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

        [HttpPost]
        public async Task<IActionResult> SeedAccounts([FromBody] List<ReceivedAccount> accounts)
        {
            using var dbContext = _dbContext;
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
        public IActionResult GetRandomAccount()
        {
            using var dbContext = _dbContext;

            var accounts = dbContext.Accounts.AsNoTracking()
                .Include(a => a.Classification)
                .Include(a => a.Alternatives)
                .ToArray();

            var randomAccount = accounts[Helpers.Helpers.GetRandomNumber(accounts.Length)];

            return Ok(randomAccount);
        }

        [HttpGet]
        [Route("alternatives")]
        public IActionResult GetAlternatives()
        {
            using var dbContext = _dbContext;

            var alts = dbContext.Alternatives.AsNoTracking()
                .Include(a => a.Account)
                .ToArray();

            return Ok(alts);
        }
    }
}
