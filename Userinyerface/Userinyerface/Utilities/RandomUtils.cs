using Fare;
using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace Userinyerface.Utilities
{
    public class RandomUtils
    {
        public static string GetRandomPassword()
        {
            var passwordRegex = new Xeger("[a-zA-Z0-9А-я]{10,30}");
            var randomPassword = passwordRegex.Generate();
            for (int i = 0; i < DataReader.configData.RandomGenerationAttemps; i++) 
            {
                if (!randomPassword.Any(char.IsDigit) && !Regex.IsMatch(randomPassword, @"\p{IsCyrillic}"))
                {
                    randomPassword = passwordRegex.Generate();
                }
                else return randomPassword;
            }
            throw new Exception("Out of attemps");
        }

        public static string GetRandomLatinString()
        {
            var emailRegex = new Xeger("[A-z]{10,30}");
            return emailRegex.Generate();
        }

        public static int GetRundomNumber(int min, int lenght)
        {
            Random random = new Random();
            return random.Next(min, lenght);
        }
    }
}