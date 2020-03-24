using System;
using Microsoft.EntityFrameworkCore;

namespace Kidcon.WebApi.Controllers
{
    public class UserController
    {
        private readonly DbContext _dbContext;

        public UserController(DbContext kidConDbContext)
        {
            _dbContext = kidConDbContext;
        }

    }
}
