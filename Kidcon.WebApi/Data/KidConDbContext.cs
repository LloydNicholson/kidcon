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
                .HasData(
                new Classification[] {
                    new Classification() { Id = 1, Type= "Asset" },
                    new Classification() { Id = 2, Type = "Expense" },
                    new Classification() { Id = 3, Type = "Drawings" },
                    new Classification() { Id = 4, Type = "Capital" },
                    new Classification() { Id = 5, Type = "Income" },
                    new Classification() { Id = 6, Type = "Liability" },
                });
            modelBuilder.Entity<Account>();
            modelBuilder.Entity<Alternative>();
        }
    }
}
