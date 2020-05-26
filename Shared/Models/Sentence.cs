using System;
namespace ClientApp.Shared.Models
{
    public enum Method
    {
        Paid,
        Received
    }

    public class Sentence
    {
        public Business Business { get; set; }
        public string BusinessName { get; set; }
        public Name Owner { get; set; }
        public Name OtherParty { get; set; }
        public Account Account { get; set; }
        public string TransactionPhrase { get; set; }
        public float TransactionAmount { get; set; }
        public Method Method { get; set; }
    }
}
