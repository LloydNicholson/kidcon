namespace KidCon.Database.Entities
{
    using System.Collections.Generic;

    public class ReceivedAccount
    {
        public string name { get; set; }
        public List<string> alts { get; set; }
        public string increasingSide { get; set; }
        public string type { get; set; }
    }
}
