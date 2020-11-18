using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Server.Data;
using ClientApp.Server.Managers.Names;
using ClientApp.Shared;
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
        private readonly KidConDbContext _dbContext;

        public NameController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

        [HttpGet]
        public IActionResult GetRandomName()
        {
            using var dbContext = OpenDbContext();

            var randomName = NameManager.GetRandomName(dbContext);

            return Ok($"{randomName.FirstName} {randomName.LastName}");
        }

        [HttpPost]
        public IActionResult AddNames([FromBody] List<Name> names)
        {
            using var dbContext = OpenDbContext();
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

        private KidConDbContext OpenDbContext()
        {
            return _dbContext ?? new KidConDbContext();
        }
    }
}
