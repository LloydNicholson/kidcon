using System;
using Kidcon.Shared;
using Microsoft.EntityFrameworkCore;

namespace Kidcon.Shared.Data
{
    public class KidConDbContext : DbContext
    {
        public KidConDbContext()
        {
        }

        public KidConDbContext(DbContextOptions<KidConDbContext> options) : base(options)
        { }

        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasKey(u => u.Id);
        }
    }
}
