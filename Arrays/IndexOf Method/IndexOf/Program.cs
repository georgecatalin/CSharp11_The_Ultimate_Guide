using System;

namespace IndexOf
{
    public class Program
    {
        public static void Main()
        {
            double[] myArray = new double[] { 10, 20, 30, 40, 50, 30 };


            int n = Array.IndexOf(myArray, 30);
            Console.WriteLine("30 was found in position " + n);

            //Array.IndexOf() only returns the first occurrence of the element in the array in linear search and stops when found

            int n1 = Array.IndexOf(myArray, 30, 3); // this is an overload of the method that starts seaching from the position 3 in the array
            Console.WriteLine("30 was found second time in position " + n1);


            Console.WriteLine();

            int n2 = Array.IndexOf(myArray, 100);
            Console.WriteLine("100 was found in the following position in the array " + n2);


            Console.ReadKey();
        }
    }
}