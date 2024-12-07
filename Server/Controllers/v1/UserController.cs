using System.Linq;
using ClientApp.Server.Data;
using Microsoft.AspNetCore.Mvc;

namespace ClientApp.Server.Controllers.v1
{
    [ApiController]
    [Route("v1/user")]
    public class UserController : ControllerBase
    {
        private readonly KidConDbContext dbContext;

        public UserController(KidConDbContext kidConDbContext)
        {
            this.dbContext = kidConDbContext;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            using var dbContext = this.OpenDbContext();
            var users = dbContext.Users.ToList();
            return this.Ok(users);
        }

        private KidConDbContext OpenDbContext()
        {
            return this.dbContext ?? new KidConDbContext();
        }
    }
}
