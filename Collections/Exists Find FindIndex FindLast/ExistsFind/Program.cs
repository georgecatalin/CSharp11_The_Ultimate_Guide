using System;

namespace ExistsFind
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 90, 85, 45, 60, 98, 85, 21 };


            Console.WriteLine("\ndisplay the initial content of the list");
            foreach (var item in myList)
            {
                Console.WriteLine(item);
            }



            bool isFailed = myList.Exists(mark => mark < 50);
            Console.WriteLine("\n\nDo there exist failed marks => " + isFailed);

            int firstFailed = myList.Find(mark => mark < 50); //If none found, it returns the default for the data type , in this case int has default 0
            Console.WriteLine("\nFirst Failed Mark "+ firstFailed);

            int firstFailedIndex = myList.FindIndex(mark => mark <50);
            Console.WriteLine("\nFirst Failed Index " + firstFailedIndex);


            int lastFailed = myList.FindLast(mark => mark < 50);
            Console.WriteLine("\nLast Failed Mark " + lastFailed);

            int lastFailedIndex = myList.FindLastIndex(mark => mark <50);
            Console.WriteLine("\nLast Failed Index " + lastFailedIndex);

            List<int> failedMarks = myList.FindAll(mark => mark < 50);

            foreach (var mark in failedMarks)
            {
                Console.WriteLine(mark);
            }

            Console.ReadKey();
        }
    }
}
