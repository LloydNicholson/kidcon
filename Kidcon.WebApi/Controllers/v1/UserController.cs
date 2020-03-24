using System;
using System.Linq;
using System.Threading.Tasks;
using Kidcon.WebApi.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Kidcon.WebApi.Controllers.v1
{
    [Route("v1/user")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly KidConDbContext _dbContext;

        public UserController(KidConDbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            using (var dbContext = OpenDbContext())
            {
                var users = dbContext.Users.ToList();
                return Ok(users);
            }
        }

        private KidConDbContext OpenDbContext()
        {
            return _dbContext ?? new KidConDbContext();
        }
    }
}
