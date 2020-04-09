using System;

namespace ClientApp.Shared.Models
{
    public class Alternative
    {
        public long Id { get; set; }
        public string AlternativePhrase { get; set; }
        public string AlternativeName { get; set; }

        public Account Account { get; set; }
    }
}
