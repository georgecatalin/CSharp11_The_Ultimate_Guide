using System;
using System.Collections.Generic;


namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a dictionary
            Dictionary<int, string> employees = new Dictionary<int, string>()
            {
                { 101, "George" },
                {102, "Sorina" },
                {103, "Mara" }
            };


            //add another element to the dictionary
            employees.Add(104, "Sorin");


            //display the elements of the dictionary
            Console.WriteLine("\nThe initial content of the dictionary is ");
            foreach(KeyValuePair<int,string> item in employees)
            {
                Console.WriteLine(item.Key + " , " + item.Value);
            }

            //display all keys
            Console.WriteLine("\nDisplaying all the keys in the dictionary");
            Dictionary<int,string>.KeyCollection theKeys = employees.Keys;

            foreach (var item in theKeys)
            {
                Console.WriteLine(item);
            }

            //display all values
            Console.WriteLine("\nDisplaying all the values in the dictionary");
            Dictionary<int, string>.ValueCollection values = employees.Values;

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }

            //remove an element from the dictionary
            bool isRemoved =employees.Remove(104);
            Console.WriteLine("\nRemoving an element from the dictionary.");
            Console.WriteLine("the element was removed => " + isRemoved);

            Console.WriteLine("\nDisplaying all the values in the dictionary");
            Dictionary<int, string>.ValueCollection theValues = employees.Values;

            foreach (var item in theValues)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nClearing the content of the dictionary");
            employees.Clear();

            Console.WriteLine("\nDisplaying all the values in the dictionary");
            foreach(KeyValuePair<int,string> item in employees) Console.WriteLine(item.Key + " , " + item.Value);

            Console.ReadKey();

        }
    }
}
