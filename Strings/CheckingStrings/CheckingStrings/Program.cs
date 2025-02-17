using System;

namespace CheckingStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string first = "Universe";
            string second = "Universe";

            //using equals()
            bool isTheSame = first.Equals(second);
            bool isTheSame2 = first == second;  // in C# for string objects , == and Equals() does the same

            Console.WriteLine("\nComparing strings with Equals(): " + isTheSame);
            Console.WriteLine("\nComparing strings with ==: " + isTheSame); // for other objects than string objects it verifies if the object on the heap is the same


            //using StartWith()
            bool startsWith = first.StartsWith('U');
            bool notStartsWith = first.StartsWith('e');
            Console.WriteLine("\nStartsWith " + startsWith);

            //using EndsWith
            bool endsWith = first.EndsWith('U');
            Console.WriteLine("\nStartsWith " + endsWith);

            //using Contains()
            bool containsChar = first.Contains('e');
            Console.WriteLine("\n ContainsChar() " + containsChar);

            bool notContainsChar = first.Contains('x');
            Console.WriteLine("\n ContainsChar() " + notContainsChar);

            //using IndexOf()
            int position = first.IndexOf('v');
            Console.WriteLine("\n Position of character " + position);

            int positionOfString = first.IndexOf("erse");
            Console.WriteLine("\n Position of string " + position);

            int positionNotExists = first.IndexOf('x');
            Console.WriteLine("\n Position of char when it does not exist in string  " + positionNotExists);

            int nextPositionSearch = first.IndexOf('e', 5); //first 'e' found in position 4
            Console.WriteLine("\nThe position of the next 'e' after the first occurrence is " + nextPositionSearch);

            Console.ReadKey();
        }
    }
}
