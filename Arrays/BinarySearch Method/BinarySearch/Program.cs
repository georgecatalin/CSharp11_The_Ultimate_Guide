using System;

namespace BinarySearch
{
    public class Program
    {
        public static void Main()
        {
            double[] thisArray = new double[] { 10, 20, 30, 40, 50, 60, 70, 80.90, 100 };

            int n = Array.BinarySearch(thisArray, 30); // note: using binary search requires that the array to be presorted, binary search is faster than linear search
            Console.WriteLine("Using binary search, 30 was found in position " + n);


            Console.WriteLine();
            int n1 = Array.BinarySearch(thisArray, 200);
            Console.WriteLine("Using binary search 200 was found in position " + n1);

            Console.ReadKey();
        }
    }
}