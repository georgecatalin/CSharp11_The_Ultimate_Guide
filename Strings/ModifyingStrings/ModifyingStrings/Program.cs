using System;

namespace ModifyingStrings
{
    internal class Program
    {
        static void Main()
        {
            string myString = "Developer";

            string newStringInsert = myString.Insert(1, "xyx"); //Dxyzeveloper

            Console.WriteLine(newStringInsert);

            string newStringRemove = myString.Remove(2, 3); //      Deoper

            Console.WriteLine(newStringRemove);

            Console.ReadKey();

        }
    }
}
