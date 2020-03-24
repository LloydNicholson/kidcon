using System;
using System.Collections.Generic;
using System.IO;
using Kidcon.Shared;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Kidcon.WebApi.Data
{
    public class KidConDbContext : DbContext
    {
        public KidConDbContext()
        {
        }

        public KidConDbContext(DbContextOptions<KidConDbContext> options) : base(options)
        { }

        public DbSet<User> Users { get; set; }
        public DbSet<Name> Names { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>();
            modelBuilder.Entity<Name>();
        }
    }
}
