using System;

namespace StrinfgsWithArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "george@gmail.com";

            char[] chars = new char[] { 'A', 'E', 'I', 'U', 'O', 'a', 'e', 'i', 'u', 'o' };

            int counterVowels = 0;

            for (int i = 0; i < myString.Length; i++)
            {
                if (Array.IndexOf(chars, myString[i]) >= 0)
                {
                    counterVowels++;
                }

            }

            Console.WriteLine($"the word {myString} has {counterVowels} vowels inside");

            Console.ReadKey();
        }
    }
}
