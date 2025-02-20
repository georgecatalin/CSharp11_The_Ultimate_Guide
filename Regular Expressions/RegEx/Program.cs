using System;
using System.Text.RegularExpressions;


namespace RegEx
{
    internal class Program
    {
        static void Main()
        {
            Regex regex_1 = new Regex("^[0-9]*$"); // this is the rule to contain only numbers from beginning ^ till the end $
            Regex regex_2 = new Regex("^[A-Za-z] *"); // this is the rule to verify for only characters and space symbol

            Console.WriteLine("Enter your message");
            string? myString = Console.ReadLine();

            if (regex_1.IsMatch(myString ?? ""))
            {
                Console.WriteLine("Your message contains only numbers");
            }
            else if (regex_2.IsMatch(myString ?? ""))
            {
                Console.WriteLine("Your message contains characters and/or a space");
            }
            else
            {
                Console.WriteLine("I can not tell you anything.");
            }


            Console.ReadKey();
        }
    }
}
