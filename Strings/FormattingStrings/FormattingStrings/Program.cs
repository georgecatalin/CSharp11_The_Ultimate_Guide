using System;


namespace FormattingStrings
{
    internal class Program
    {
        static void Main()
        {
            string name = "George";
            string role = "Project Manager";

            string newString = string.Format("{0} has the role of {1}.", name, role);

            Console.WriteLine("\nThe new string obtained with string.Format() " +  newString);


            string newStringPlaceholders = $"{name} has the {role}.";
            Console.WriteLine("\nThe new string obtained with $\" ... \" " + newStringPlaceholders);

            Console.ReadKey();

        }
    }
}
