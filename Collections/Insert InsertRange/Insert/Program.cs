using System;
using System.Collections.Generic;


namespace Insert
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 10, 20, 30 };

            Console.WriteLine();
            Console.WriteLine("This is the initial list");

            foreach (int i in myList) Console.WriteLine(i);


            myList.Insert(1, 325);

            Console.WriteLine();
            Console.WriteLine("This is the list after insert an element at position 1");

            foreach (int i in myList) Console.WriteLine(i);


            List<int> newList = new List<int>() { 50, 55, 60 };
            myList.InsertRange(2, newList);

            Console.WriteLine();
            Console.WriteLine("This is the list after insert a range of elements  at position 2 "); // 10 325 50 55 60 20 30
            foreach (int i in myList) Console.WriteLine(i);

            Console.ReadKey();
        }
    }
}
