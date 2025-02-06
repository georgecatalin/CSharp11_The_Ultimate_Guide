using System;
using System.Collections.Generic;


namespace SortedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a sorted list
            SortedList<int, string> myList = new SortedList<int, string>()
            {
                {103, "Mara" },
                {102, "Sorina" },
                {104, "George" },
                {101, "Sorin" }
            };


            //add new element to the list
            myList.Add(100, "Pavel");


            //display all the elements
            foreach (KeyValuePair<int, string> item in myList)
            {
                Console.WriteLine(item.Key + " , " + item.Value);
            }

            //display all keys
            IList<int> keys = myList.Keys;

            foreach (int item in keys)
            {
                Console.WriteLine(item);
            }


            //display all values

            IList<string> values = myList.Values;

            foreach (var item in values) Console.WriteLine(item);

            //verify if contains key

            bool doesContainKey = myList.ContainsKey(100);
            Console.WriteLine("\n 100 exists in the sorted list : " + doesContainKey);

            bool doesContainValue = myList.ContainsValue("George");
            Console.WriteLine("\n \"George\" exists in the sorted list : " + doesContainValue);

            //display the index of a key
            int indexOfKey = myList.IndexOfKey(100);
            Console.WriteLine("\nThe index of the key 100 is " + indexOfKey);


            //display the index of the value
            int indexOfValue = myList.IndexOfValue("Mara");
            Console.WriteLine("\nThe index of the value \"Mara\" is " + indexOfValue);

            //clear the sorted list
            myList.Clear();
            foreach (KeyValuePair<int, string> item in myList) Console.WriteLine(item.Key + " , " + item.Value);

            Console.ReadKey();

        }
    }
}
