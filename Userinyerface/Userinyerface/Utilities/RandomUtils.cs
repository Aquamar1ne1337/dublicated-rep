using Fare;
using System;

namespace Userinyerface.Utilities
{
    public class RandomUtils
    {
        public static string GetRandomPassword()
        {
            var passwordRegex = new Xeger("[a-zA-Z0-9А-я]{10,30}");
            return passwordRegex.Generate();
        }

        public static string GetRandomLatinString()
        {
            var emailRegex = new Xeger("[A-z]{10,30}");
            return emailRegex.Generate();
        }

        public static int GetRundomNumber(int lenght)
        {
            Random random = new Random();
            return random.Next(0, lenght);
        }
    }
}