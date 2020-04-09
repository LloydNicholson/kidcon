using System;
using System.Collections.Generic;

namespace ClientApp.Shared.Models
{
    public class ReceivedAccount
    {
        public string name { get; set; }
        public List<string> alts { get; set; }
        public string increasingSide { get; set; }
        public string type { get; set; }
    }
}
