using System;


namespace SearchStringsWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "george.calin@gmail.com";
            char[] chars = new char[] { 'A', 'a', 'E', 'e', 'I', 'i', 'U', 'u', 'O', 'o' };


            int counterVowels = 0;

            counterVowels = myString.Count(letter => Array.IndexOf(chars, letter) >= 0);

            Console.WriteLine($"The word {myString} has {counterVowels} vowels. ");

            Console.ReadKey();

        }
    }
}
