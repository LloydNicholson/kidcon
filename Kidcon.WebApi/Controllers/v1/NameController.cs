using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Kidcon.WebApi.Data;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Kidcon.WebApi
{
    [Route("api/[controller]")]
    public class NameController : Controller
    {
        private readonly KidConDbContext _dbContext;

        public NameController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }
    }
}
