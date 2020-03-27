
using System.Collections.Generic;

namespace Kidcon.Shared.Models
{
    public class Classification
    {
        public long Id { get; set; }
        public string Type { get; set; }

        public ICollection<Account> Accounts { get; set; }
    }
}