using System;
using System.Collections.Generic;
using System.IO;
using Kidcon.Shared.Models;
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
        {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Name> Names { get; set; }
        public DbSet<Classification> Classifications { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Alternative> Alternatives { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Name>();
            modelBuilder.Entity<Classification>()
                .HasMany(e => e.Accounts)
                .WithOne(e => e.Classification);
            modelBuilder.Entity<Account>();
            modelBuilder.Entity<Alternative>().HasOne(e => e.Account);
        }
    }
}
