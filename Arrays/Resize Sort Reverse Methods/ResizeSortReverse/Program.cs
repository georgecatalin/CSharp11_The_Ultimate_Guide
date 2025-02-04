using System;

namespace Resize
{
    public class Program
    {
        public static void Main()
        {
            //declare the array
            int[] myArray = new int[] { 10, 20, 30};

            Console.WriteLine();


            //print the array 
            Console.WriteLine("The initial array is ");


            foreach(int i in myArray) Console.WriteLine(i);


            Console.WriteLine();

            //resize array
            Array.Resize(ref myArray, 10);

            //print the new array, newly created positions are set to initial values of the type, for int it is 0
            foreach (var i in myArray) Console.WriteLine(i);


            Console.WriteLine();

            //resize array to diminishing size

            Array.Resize(ref myArray, 5);

            //display modified array
            foreach (var i in myArray) Console.WriteLine(i);


            Console.WriteLine();
            Console.WriteLine("Sort the array ascending");

            Array.Sort(myArray);

            //display sorted array
            foreach (var i in myArray) Console.WriteLine(i);

            Console.WriteLine();
            Console.WriteLine("Sort the array descending");

            Array.Reverse(myArray);

            //display reversed array
            for(int i = 0; i<myArray.Length; i++) Console.WriteLine(myArray[i]);

            Console.ReadKey();

        }
    }
}