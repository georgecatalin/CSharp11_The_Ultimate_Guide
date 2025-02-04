using System;
using System.Collections.Generic;

namespace Remove
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30, 40, 50, 60 ,70 };

            //display the list
            Console.WriteLine();
            Console.WriteLine("The content of the initial list");

            foreach (int i in myList) Console.WriteLine(i); 


            myList.Remove(30);
            //display the list
            Console.WriteLine();
            Console.WriteLine("The content of the  list");

            foreach (int i in myList) Console.WriteLine(i); // 10 20 40 50 60 70

            myList.RemoveAt(1); // Removes 20

            //display the list
            Console.WriteLine();
            Console.WriteLine("The content of the  list");

            foreach (int i in myList) Console.WriteLine(i); // 10 40 50 60 70


            myList.RemoveRange(1, 2); // removes 40 50
            //display the list
            Console.WriteLine();
            Console.WriteLine("The content of the  list");

            foreach (int i in myList) Console.WriteLine(i); // 10 60 70


            myList.RemoveAll(n => n > 50); // Removes 60 70
                                           //display the list
            Console.WriteLine();
            Console.WriteLine("The content of the  list");

            foreach (int i in myList) Console.WriteLine(i); // 10


            myList.Clear(); // removes anything
            //display the list
            Console.WriteLine();
            Console.WriteLine("The content of the  list");

            foreach (int i in myList) Console.WriteLine(i);


        }
    }
}
