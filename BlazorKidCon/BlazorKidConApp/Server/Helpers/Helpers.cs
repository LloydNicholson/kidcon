using System;
using System.Timers;

namespace BlazorKidConApp.Server.Helpers
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
