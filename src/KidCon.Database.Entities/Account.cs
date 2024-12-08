namespace KidCon.Database.Entities
{
    using System.Collections.Generic;

    public class Account
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string IncreasingSide { get; set; }

        public ICollection<Alternative> Alternatives { get; set; }
        public Classification Classification { get; set; }
    }
}
