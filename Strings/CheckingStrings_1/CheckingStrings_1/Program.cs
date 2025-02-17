using System;


namespace CheckingStrings_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myString = "Developer";



            //using LastIndexOf() with its overloads
            int lastIndex = myString.LastIndexOf('e'); //7
            Console.WriteLine("\nlastIndex of 'e' in \"developer\" " + lastIndex);

            int lastIndexOfString = myString.LastIndexOf("lo"); //4
            Console.WriteLine("\nlastIndex of 'lop' in \"developer\" " + lastIndexOfString);

            int lastIndexWithPosition = myString.LastIndexOf('e', 2); //counts from the position 2 in the string leftwards so it is 1
            Console.WriteLine("\nlastIndex of 'e' in \"developer\" starting from 2 : " + lastIndexWithPosition);

            //using IsNullOrEmpty(), IsNullOrWhiteSpace()
            string userInput = null;
            string userInput1 = "";
            string userInput2 = " ";
            string userInput3 = "some word";

            bool isValid = string.IsNullOrEmpty(userInput); //true
            bool isValid1 = string.IsNullOrEmpty(userInput1); //true
            bool isValid2 = string.IsNullOrEmpty(userInput2); //false
            bool isValid3 = string.IsNullOrEmpty(userInput3); //false

            bool isValid_1 = string.IsNullOrWhiteSpace(userInput); //true
            bool isValid1_1 = string.IsNullOrWhiteSpace(userInput1); //true
            bool isValid2_1 =string.IsNullOrWhiteSpace(userInput2); // true
            bool isValid3_1 = string.IsNullOrWhiteSpace(userInput3); //false

            Console.WriteLine(isValid + "\t" +  isValid1 + "\t" + isValid2 + "\t" + isValid3);
            Console.WriteLine(isValid_1 + "\t" + isValid1_1 + "\t" + isValid2_1 + "\t" + isValid3_1);

            Console.ReadKey();
        }
    }
}
