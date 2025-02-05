using System;

namespace SortReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int>() { 10, 20, 40, 30, 40, 50, 60, 70, 80 };


            Console.WriteLine();
            Console.WriteLine("display the list in the initial form ");

            for (int i = 0; i < list.Count; i++) {Console.WriteLine(list[i]);}


            Console.WriteLine();
            list.Sort();
            Console.WriteLine("display the list in the sorted form");

            for (int i = 0; i < list.Count; i++)
            { 
                Console.WriteLine(list[i]);
            }

            Console.WriteLine();
            list.Reverse();
            Console.WriteLine("display the list in the reversed form ");

            for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }


            Console.ReadKey();
        }
    }
}
