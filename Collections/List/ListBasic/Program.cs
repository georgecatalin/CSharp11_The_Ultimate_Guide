using System;
using System.Collections.Generic;


namespace ListBasic
{
    public class Program
    {
        public static void Main()
        {
            //create the reference variable of type List Class and store in it the newly created object of type List in the heap
            List<int> myList = new List<int>() { 10, 20, 30 };

            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("displaying the list using for loop statement");


            for(int i =0; i<myList.Count; i++)
            {
                Console.WriteLine(myList[i]);
            }

            Console.WriteLine();
            //internally the lists, as well as all the collection types use arrays when handling data. A new array is created and data copied onto it, while the old array is deleted at any add
            List<int> myFastList = new List<int>(10) { 10, 20, 30 };

            // in the previous case I use the Capacity parameter overload so that a single internal array is created at once up to reaching 10 elements of storage, and only when the 11th element is added the new array is created
            foreach (int i in myFastList)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine("displaying the list using for loop statement");


            for (int i = 0; i <myFastList.Count; i++)
            {
                Console.WriteLine(myFastList[i]);
            }


        }
    }
}