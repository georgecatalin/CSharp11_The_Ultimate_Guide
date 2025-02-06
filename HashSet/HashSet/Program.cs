using System;
using System.Collections.Generic;


namespace HashSet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a hashset object
            HashSet<string> hashset1 = new HashSet<string>()
            {
                "George", "Sorina", "Mara", "Sandu"
            };

            //print the hashset
            foreach (string s in hashset1)
            {
                Console.WriteLine(s);
            }

            //get the number of elements stored in the hashset, values stored must be unique, only one null allowed
            int number = hashset1.Count;
            Console.WriteLine("\nThe number of values in the hashset is " +  number);


            //add new element to hashset
            hashset1.Add("Vali");

            Console.WriteLine("\nAfter adding the new value, this is the hashset count " +  hashset1.Count);
            //print the hashset
            foreach (string s in hashset1)
            {
                Console.WriteLine(s);
            }


            //remove one value from hashset
            hashset1.Remove("George"); //remove is case sensitive
            Console.WriteLine("\nAfter removing the  value, this is the hashset count " + hashset1.Count);
            //print the hashset
            foreach (string s in hashset1)
            {
                Console.WriteLine(s);
            }

            //remove value based on condition
            hashset1.RemoveWhere(value => value.Equals("Mara"));
            Console.WriteLine("\nAfter removing the  value, this is the hashset count " + hashset1.Count);
            //print the hashset
            foreach (string s in hashset1)
            {
                Console.WriteLine(s);
            }

            //verify if the hashset contains a certain value
            bool containsValue = hashset1.Contains("Mara"); //is case sensitive
            Console.WriteLine("\nThe hashset contains the Mara value =>" + containsValue);


            //clear the hashset collection
            hashset1.Clear();
            Console.WriteLine("\nAfter clearing , this is the hashset count " + hashset1.Count);
            //print the hashset
            foreach (string s in hashset1)
            {
                Console.WriteLine(s);
            }


            //demonstrate unionwith(), intersectwith() methods of the hashset class
            HashSet<string> countries1 = new HashSet<string>()
            {
                "Romania", "Ireland", "Iran", "Israel"
            };

            HashSet<string> countries2 = new HashSet<string>()
            {
                "United States", "Russia", "Hungary"
            };


            countries1.UnionWith(countries2);
            Console.WriteLine("\nDemonstrate UnionWith()");
            foreach (string s in countries1)  Console.WriteLine(s);


            HashSet<string> cars1 = new HashSet<string>()
            {
                "Dacia", "Renault", "Volkswagen", "BMW"
            };

            HashSet<string> cars2 = new HashSet<string>()
            {
                "Dacia", "Renault", "Skoda", "Audi"
            };


            cars1.IntersectWith(cars2);
            Console.WriteLine("\nDemonstrate IntersectWith()");
            foreach (string item in cars1)
            {
                Console.WriteLine(item);
            }



            Console.ReadKey();
        }
    }
}
