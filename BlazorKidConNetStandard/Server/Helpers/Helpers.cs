using System;
using System.Timers;

namespace ClientApp.Server.Helpers
{
    public class Helpers
    {
        public static int GetRandomNumber(int limit)
        {
            var randomNum = new Random().Next(limit);
            return randomNum;
        }
    }
}
