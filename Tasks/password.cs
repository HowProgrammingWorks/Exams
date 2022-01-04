using System;

namespace ConsoleApplication2
{
    internal class Password
    {
        private static Random _random = new Random();
        
        public static void Main()
        {
            string result = GeneratePassword("abc123", 7);
            Console.WriteLine(result);
        }

        private static string GeneratePassword(string alphabet, int passwordLength)
        {
            int maxAlphabetIndex = alphabet.Length;
            string password = "";
            for (int i = 0; i < passwordLength; i++)
            {
                int index = (int) Math.Floor(_random.NextDouble() * maxAlphabetIndex);
                password += alphabet[index];
            }

            return password;
        }
    }
}