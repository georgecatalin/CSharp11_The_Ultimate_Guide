using System;
using System.Collections.Generic;

namespace AddAddRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create the reference variable on the stack and store the address of  the newly created list class object on the heap
            List<int> myList = new List<int>() { 10, 20, 30 };


            Console.WriteLine();
            Console.WriteLine("The content of the initial list");
            //display the contents of the list on the screen
            foreach (int i in myList) Console.WriteLine(i);

            //Add a new element to the list
            myList.Add(40);

            Console.WriteLine();
            Console.WriteLine("The content of the list after adding the new element");

            //display the contents of the list on the screen
            foreach (int i in myList) Console.WriteLine(i);

            //Add multiple elements at once at the list
            List<int> secondList = new List<int>() { 40, 50, 60, 70 };

            myList.AddRange(secondList);

            Console.WriteLine();
            Console.WriteLine("The content of the list after adding multiple  elements at once");

            //display the contents of the list on the screen
            foreach (int i in myList) Console.WriteLine(i);
        }
    }
}
