
namespace KidCon.Database.Entities
{
    using System.Collections.Generic;

    public class Classification
    {
        public long Id { get; set; }
        public string Type { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}