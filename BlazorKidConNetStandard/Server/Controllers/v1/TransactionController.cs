using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Server.Data;
using ClientApp.Server.Managers.Accounts;
using ClientApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Server.Controllers.v1
{
    [ApiController]
    [Route("v1/transaction")]
    public class TransactionController : ControllerBase
    {
        private readonly KidConDbContext _dbContext;

        public TransactionController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }


        [HttpGet]
        [Route("sentence/{length}")]
        public async Task<ActionResult<List<Sentence>>> GenerateSentencesAsync(int length)
        {
            using var dbContext = OpenDbContext();

            var sentences = await AccountManager.GenerateSentences(dbContext, length, BusinessType.Service);

            return Ok(sentences);
        }

        private KidConDbContext OpenDbContext()
        {
            return _dbContext ?? new KidConDbContext();
        }
    }
}
