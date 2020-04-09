using System;
using System.Collections.Generic;

namespace ClientApp.Shared.Models
{
    public class Account
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string IncreasingSide { get; set; }

        public ICollection<Alternative> Alternatives { get; set; }
        public Classification Classification { get; set; }
    }
}
