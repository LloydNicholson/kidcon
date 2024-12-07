using System.Collections.Generic;
using System.Linq;
using ClientApp.Server.Data;
using ClientApp.Shared.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientApp.Server.Controllers.v1
{
    [ApiController]
    [Route("v1/name")]
    public class NameController : ControllerBase
    {
        private readonly KidConDbContext dbContext;

        public NameController(KidConDbContext kidConDbContext)
        {
            this.dbContext = kidConDbContext;
        }

        [HttpGet]
        public IActionResult GetRandomName()
        {
            using var dbContext = this.dbContext;
            var names = dbContext.Names.AsNoTracking()
                .ToArray();

            var randomFirstName = names[Helpers.Helpers.GetRandomNumber(names.Length)].FirstName;
            var randomLastName = names[Helpers.Helpers.GetRandomNumber(names.Length)].LastName;

            return this.Ok($"{randomFirstName} {randomLastName}");
        }

        [HttpPost]
        public IActionResult AddNames([FromBody] List<Name> names)
        {
            using var dbContext = this.dbContext;
            var newNames = new List<Name>();

            foreach (var name in names)
            {
                var createdName = new Name { FirstName = name.FirstName, LastName = name.LastName };
                newNames.Add(createdName);
            }

            dbContext.Names.AddRange(newNames);
            dbContext.SaveChanges();

            return this.Ok(newNames);
        }

    }
}
