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

            // using Replace()
            string myString_replace_chars = myString.Replace('e', 'a');
            Console.WriteLine("\nThe new string with Replace('e', 'a') :" + myString_replace_chars);
            Console.WriteLine("the old string : " + myString);  // the original string does not change. RULE strings are immutable

            string myString_replace_string = myString.Replace("loper","order");
            Console.WriteLine("\nThe new string with Replace('e', 'a') :" + myString_replace_string);
            Console.WriteLine("the old string : " + myString);  // the original string does not change. RULE strings are immutable

            //using Split()
            string myNewString = "Hello from Galati";
            string[] mySplitArray = myNewString.Split(' ');
            Console.WriteLine("\nThe split strings are :");
            foreach (string str in mySplitArray) Console.WriteLine(str);

            //using Trim()
            string myStringWithSpaces = " Hello World  ";
            string myTrimmedString = myString.Trim();
            Console.WriteLine("\nThe trimmed string is " + myTrimmedString);
            Console.WriteLine("the old string : " + myStringWithSpaces);  // the original string does not change. RULE strings are immutable

            //using ToCharArray()
            char[] myCharArray = myString.ToCharArray();
            Console.WriteLine("\nThis is the Char Array: ");
            foreach (var item in myCharArray) Console.WriteLine(item);


            //using String.Join
            string[] myWords = new string[] { "Hello", "How", "are", "you" };
            string joinedString = string.Join('-',myWords);
            Console.WriteLine("\nUsing string.join(): " + joinedString);

            //using the string constructor from a char array
            char[] myCharArray2 = new char[] { 'a', 'b', 'c', 'd', 'e' };
            string constructedString = new string(myCharArray2);
            Console.WriteLine("\nThe string with the char array in the constructor: " + constructedString);



            Console.ReadKey();
        }
    }
}
