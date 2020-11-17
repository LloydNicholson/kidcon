using System;
using System.Collections.Generic;
using System.IO;
using ClientApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace ClientApp.Server.Data
{
    public class KidConDbContext : DbContext, IKidConDbContext
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
        public DbSet<Business> Businesses { get; set; }
        public DbSet<Sentence> Sentences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>();
            modelBuilder.Entity<Name>();
            modelBuilder.Entity<Classification>()
                .HasData(
                new List<Classification>() {
                    new Classification() { Id = 1, Type= "Asset" },
                    new Classification() { Id = 2, Type = "Expense" },
                    new Classification() { Id = 3, Type = "Drawings" },
                    new Classification() { Id = 4, Type = "Capital" },
                    new Classification() { Id = 5, Type = "Income" },
                    new Classification() { Id = 6, Type = "Liability" },
                });
            modelBuilder.Entity<Alternative>();
            modelBuilder.Entity<Business>()
                .HasData(
                new List<Business>()
                {
                    new Business() { Id = 1, Type = BusinessType.Service, Description = "Builder"},
                    new Business() { Id = 2, Type = BusinessType.Service, Description = "Plumber"},
                    new Business() { Id = 3, Type = BusinessType.Service, Description = "Electrician"},
                    new Business() { Id = 4, Type = BusinessType.Service, Description = "Accountant"},
                    new Business() { Id = 5, Type = BusinessType.Service, Description = "Painter"},
                    new Business() { Id = 6, Type = BusinessType.Service, Description = "Gardener"},
                    new Business() { Id = 7, Type = BusinessType.Service, Description = "Dancer"},
                    new Business() { Id = 8, Type = BusinessType.Product, Description = "Art Supplier"},
                });
            modelBuilder.Entity<Account>();
            //.HasData(
            //new List<Account>()
            //{
            //    new Account() { Id = 1, Name = "Trading stock", IncreasingSide = "debit" },
            //    new Account() { Id = 2, Name = "Vehicles", IncreasingSide = "debit" },
            //    new Account() { Id = 3, Name = "Equipment", IncreasingSide = "debit" },
            //    new Account() { Id = 4, Name = "Machinery", IncreasingSide = "debit" },
            //    new Account() { Id = 5, Name = "Land and buildings", IncreasingSide = "debit" },
            //    new Account() { Id = 6, Name = "Petty Cash", IncreasingSide = "debit" },
            //    new Account() { Id = 7, Name = "Cash float", IncreasingSide = "debit" },
            //    new Account() { Id = 8, Name = "Furniture", IncreasingSide = "debit" },
            //    new Account() { Id = 9, Name = "Bank", IncreasingSide = "debit" },
            //    new Account() { Id = 10, Name = "Drawings", IncreasingSide = "debit" },
            //    new Account() { Id = 11, Name = "Salaries", IncreasingSide = "debit" },
            //    new Account() { Id = 12, Name = "Wages", IncreasingSide = "debit" },
            //    new Account() { Id = 13, Name = "Repairs", IncreasingSide = "debit" },
            //    new Account() { Id = 14, Name = "Advertising", IncreasingSide = "debit" },
            //    new Account() { Id = 15, Name = "Telephone", IncreasingSide = "debit" },
            //    new Account() { Id = 16, Name = "Stationery", IncreasingSide = "debit" },
            //    new Account() { Id = 17, Name = "Water and electricity", IncreasingSide = "debit" },
            //    new Account() { Id = 18, Name = "Insurance", IncreasingSide = "debit" },
            //    new Account() { Id = 19, Name = "Packing material", IncreasingSide = "debit" },
            //    new Account() { Id = 20, Name = "Fuel", IncreasingSide = "debit" },
            //    new Account() { Id = 21, Name = "Bank charges", IncreasingSide = "debit" },
            //    new Account() { Id = 22, Name = "Consumable goods", IncreasingSide = "debit" },
            //    new Account() { Id = 23, Name = "Interest on loan", IncreasingSide = "debit" },
            //    new Account() { Id = 24, Name = "Interest expense", IncreasingSide = "debit" },
            //    new Account() { Id = 25, Name = "Postage", IncreasingSide = "debit" },
            //    new Account() { Id = 26, Name = "Donations expense", IncreasingSide = "debit" },
            //    new Account() { Id = 27, Name = "Rent expense", IncreasingSide = "debit" },
            //    new Account() { Id = 28, Name = "Cost of Sales", IncreasingSide = "debit" },
            //    new Account() { Id = 29, Name = "Loan", IncreasingSide = "credit" },
            //    new Account() { Id = 30, Name = "Mortgage bond", IncreasingSide = "credit" },
            //    new Account() { Id = 31, Name = "Bank overdraft", IncreasingSide = "credit" },
            //    new Account() { Id = 32, Name = "Creditors Control", IncreasingSide = "credit" },
            //    new Account() { Id = 33, Name = "Current income", IncreasingSide = "credit" },
            //    new Account() { Id = 34, Name = "Rent income", IncreasingSide = "credit" },
            //    new Account() { Id = 35, Name = "Donations income", IncreasingSide = "credit" },
            //    new Account() { Id = 36, Name = "Commission", IncreasingSide = "credit" },
            //    new Account() { Id = 37, Name = "Sales", IncreasingSide = "credit" },
            //    new Account() { Id = 38, Name = "Interest income", IncreasingSide = "credit" },
            //    new Account() { Id = 39, Name = "Interest on fixed deposit", IncreasingSide = "credit" },
            //    new Account() { Id = 40, Name = "Capital", IncreasingSide = "credit" },
            //});
            modelBuilder.Entity<Sentence>();
        }
    }
}
