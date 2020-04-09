using System;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Server.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ClientApp.Server.Controllers.v1
{
    [ApiController]
    [Route("v1/user")]
    public class UserController : ControllerBase
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
