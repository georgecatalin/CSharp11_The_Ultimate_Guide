using System;

namespace StringsWithForLoop
{
    internal class Program
    {
        static void Main()
        {
            string myString = "Developer";

            char[] vowelsArray = new char[] { 'A', 'E', 'I', 'U', 'O', 'a', 'e', 'i', 'u', 'o' };

            int counterVowels = 0;

            for (int i = 0; i < myString.Length; i++)
            {
                bool isVowel = false;
                for (int j = 0; j < vowelsArray.Length; j++)
                {
                    if (myString[i] == vowelsArray[j])
                    {
                        isVowel = true;
                        counterVowels++;
                    }


                }
                Console.WriteLine(myString[i] + " -> " + isVowel);
            }
            Console.WriteLine("I found that many matches " + counterVowels);
        }
    }
}
