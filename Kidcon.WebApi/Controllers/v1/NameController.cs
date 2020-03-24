using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kidcon.Shared;
using Kidcon.WebApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kidcon.WebApi.Controllers.v1
{
    [Route("v1/name")]
    public class NameController : Controller
    {
        private readonly KidConDbContext _dbContext;

        public NameController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

        [HttpGet]
        public IActionResult GetRandomName()
        {
            using (var dbContext = _dbContext)
            {
                var names = dbContext.Names.AsNoTracking()
                    .ToArray();

                var randomFirstName = names[GetRandomNumber(names.Length)].FirstName;
                var randomLastName = names[GetRandomNumber(names.Length)].LastName;

                return Ok($"{randomFirstName} {randomLastName}");
            }
        }

        [HttpPost]
        public IActionResult AddNames([FromBody] List<Name> names)
        {
            using var dbContext = _dbContext;
            var newNames = new List<Name>();

            foreach (var name in names)
            {
                var createdName = new Name { FirstName = name.FirstName, LastName = name.LastName };
                newNames.Add(createdName);
            }

            dbContext.Names.AddRange(newNames);
            dbContext.SaveChanges();

            return Ok(newNames);
        }

        private int GetRandomNumber(int limit)
        {
            var randomNum = new Random().Next(limit);
            return randomNum;
        }
    }
}
