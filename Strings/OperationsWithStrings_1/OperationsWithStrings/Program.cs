using System;


namespace OperationsWithStrings
{
    internal class Program
    {
        static void Main()
        {
            string myString = "Developer";

            Console.WriteLine(myString);

            string myStringToLower = myString.ToLower();
            Console.WriteLine("using ToLower(): "+ myStringToLower);
            Console.WriteLine("the old string : " + myString);  // the original string does not change. RULE strings are immutable

            string myStringToUpper = myString.ToUpper();
            Console.WriteLine("\nusing ToUpper(): " + myStringToUpper);
            Console.WriteLine("the old string : " + myString);  // the original string does not change. RULE strings are immutable


            // Developer
            string vel = myString.Substring(2, 3);
            Console.WriteLine("\nusing Substring(2,3): " + vel);
            Console.WriteLine("the old string : " + myString);  // the original string does not change. RULE strings are immutable

            string veloper =  myString.Substring(2);
            Console.WriteLine("\nusing Substring(2): " + veloper);
            Console.WriteLine("the old string : " + myString);  // the original string does not change. RULE strings are immutable

            Console.ReadKey();
        }
    }
}
