using System;


namespace IndexOf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 20, 30, 40, 50, 40, 60 };


            int n = list.IndexOf(40); // IndexOf() searches linearly at stops when it finds the value for the first time
            Console.WriteLine();
            Console.WriteLine("We found 40 at the following position " + n);


            Console.WriteLine();
            int n1 = list.IndexOf(100);
            Console.WriteLine("We found 100 at the following position " + n1);


            Console.WriteLine();
            int n2 = list.IndexOf(40, n + 1);
            Console.WriteLine("We found 40 supplementarily at the following position " + n2);


            //BinarySearch() perform binarysearch , hence it is faster , but it requires that the list is presorted
            Console.WriteLine();
            int n3 = list.BinarySearch(30);
            Console.WriteLine("We found 30 using binary search at the following position " + n3);


            //Contains() returns a bool and verifies if the list contains the value or not
            Console.WriteLine();
            bool containsValue = list.Contains(40);
            Console.WriteLine("The list contains value 40 => "+ containsValue);

            Console.ReadKey();

            
        }
    }
}
