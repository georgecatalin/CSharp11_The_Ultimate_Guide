using System;

namespace HowStringsAreCreated
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string x = "Hello, World!";
            string y = "Hello, World!"; //the CLR observes internally there is the same System.String object in the heap and it does not create a new object. y points to the same object and contains its address

            Console.WriteLine("x=" +x);
            Console.WriteLine("y=" + y);

            string z = x; // the address of the string "Hello, World!" in the heap is stored also in z
            Console.WriteLine("y=" + y);


            x = "I am hungry"; // a new System.String object is created on the heap memory and x points to this. x stored its address
            Console.WriteLine("x=" + x);  // I am hungry

            Console.WriteLine("y=" + y); // Hello, World! -> y still stored the address to the object "Hello, World!" in the heap, nothing changed about it
            Console.WriteLine("z=" + z); // Hello, World! -> z still stored the address to the object "Hello, World!" in the heap, nothing changed about it

            Console.ReadKey();
        }
    }
}
