using System;
using System.Linq;
using ClientApp.Server.Data;
using ClientApp.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace ClientApp.Server.Managers.Names
{
    public static class NameManager
    {
        public static Name GetRandomName(KidConDbContext dbContext)
        {
            var names = dbContext.Names.AsNoTracking().ToArray();

            var randomFirstName = names[Helpers.Helpers.GetRandomNumber(names.Length)].FirstName;
            var randomLastName = names[Helpers.Helpers.GetRandomNumber(names.Length)].LastName;

            var name = new Name()
            {
                FirstName = randomFirstName,
                LastName = randomLastName
            };

            return name;
        }

        public static Business GetRandomBusiness(KidConDbContext dbContext)
        {
            var businesses = dbContext.Businesses.AsNoTracking().ToArray();

            var randomBusinessName = businesses[Helpers.Helpers.GetRandomNumber(businesses.Length)];

            return randomBusinessName;
        }
    }
}
