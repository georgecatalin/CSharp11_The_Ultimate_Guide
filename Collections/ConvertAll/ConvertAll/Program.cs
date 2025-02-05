using System;


namespace ConvertAll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> myList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("\nThe initial status of the list is ");
            foreach (int i in myList) Console.WriteLine(i);


            List<string> convertedList = myList.ConvertAll<string>(item =>
            {
                string word;

                switch (item)
                {
                    case 1: word = "one"; break;
                    case 2: word = "two"; break;
                    case 3: word = "three"; break;
                    case 4: word = "four"; break;
                    case 5: word = "five"; break;
                    case 6: word = "six"; break;
                    case 7: word = "seven"; break;
                    case 8: word = "eight"; break;
                    case 9: word = "nine"; break;
                    default: word = ""; break;
                }

                return word;
      
            });


            Console.WriteLine("\ndisplay converted list of strings ");

            foreach (var item in convertedList)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
