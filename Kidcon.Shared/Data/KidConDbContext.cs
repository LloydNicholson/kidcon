using System;
using Kidcon.Shared;
using Microsoft.EntityFrameworkCore;

namespace Kidcon.WebApi
{
    public class KidConDbContext
    {
        public KidConDbContext()
        {
        }

        public DbSet<User> User { get; set; }
    }
}
