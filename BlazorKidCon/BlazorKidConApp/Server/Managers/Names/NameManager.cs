using System;
using System.Linq;
using System.Threading.Tasks;
using BlazorKidConApp.Server.Data;
using BlazorKidConApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorKidConApp.Server.Managers.Names
{
    public static class NameManager
    {
        public static async Task<Name> GetRandomName(KidConDbContext dbContext)
        {
            var names = await dbContext.Names.AsNoTracking().ToArrayAsync();

            var randomFirstName = names[Helpers.Helpers.GetRandomNumber(names.Length)].FirstName;
            var randomLastName = names[Helpers.Helpers.GetRandomNumber(names.Length)].LastName;

            var name = new Name()
            {
                FirstName = randomFirstName,
                LastName = randomLastName
            };

            return name;
        }

        public static async Task<Business> GetRandomBusiness(KidConDbContext dbContext)
        {
            var businesses = await dbContext.Businesses.AsNoTracking().ToArrayAsync();

            var randomBusinessName = businesses[Helpers.Helpers.GetRandomNumber(businesses.Length)];

            return randomBusinessName;
        }
    }
}
