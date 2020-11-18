using ClientApp.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClientApp.Server.Data
{
    public interface IKidConDbContext
    {
        DbSet<User> Users { get; set; }
        DbSet<Name> Names { get; set; }
        DbSet<Classification> Classifications { get; set; }
        DbSet<Account> Accounts { get; set; }
        DbSet<Alternative> Alternatives { get; set; }
        DbSet<Business> Businesses { get; set; }
        DbSet<Sentence> Sentences { get; set; }
    }
}
