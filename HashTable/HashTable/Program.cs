using System;
using System.Collections;


namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //create a hashtable
            Hashtable hashtable = new Hashtable()
            {
                {100, "George" },
                {101, "Mara" },
                {102, "Sorina" },
                {"Pavel", "Sorin" }
            };

            //add element to hashtable
            hashtable.Add(105, "Cristian");


            //print the hashtable 
            Console.WriteLine("Printing the hashtable");

            foreach (var item in hashtable)
            {
                Console.WriteLine(item);
            }

            //remove element from hashtable
            hashtable.Remove(105);

            Console.WriteLine("\nPrinting the hashtable after deleting the element");

            foreach(var item in hashtable)
            {
                Console.WriteLine(item);
            }


            //get element at hashtable index
            if (hashtable[100] is string)
            {
                Console.WriteLine("Element is " + hashtable[100]);
                Console.WriteLine();
            }

            if (hashtable[100] is double)
            {
                Console.WriteLine(Convert.ToDouble(hashtable[100]));
            }


            //verify if contains key
            bool hasKey = hashtable.ContainsKey(100);
            Console.WriteLine("The hashtable contains the key => " + hasKey);

            //verify if contains value
            bool hasValue = hashtable.ContainsValue("George");
            Console.WriteLine("The hashtable contains the value => " +  hasValue);

            //print the keys
            ICollection keys = hashtable.Keys;
            Console.WriteLine("\nPrinting the keys in the hashtable");
            foreach (var key in keys)
            {
                Console.WriteLine(key);
            }

            //print the values
            ICollection  values = hashtable.Values;
            Console.WriteLine("\nPrinting the values in the hashtable");
            foreach (var value in values)
            {
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
