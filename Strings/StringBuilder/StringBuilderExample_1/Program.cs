using System;
using System.Text;

namespace StringBuilderExample_1
{
    internal class Program
    {
        static void Main()
        {
            //create a string array
            string[] myArray = new string[] { "the", "quick", "brown" ,"fox", "jumps", "over", "the", "lazy", "dog" };


            //an example with string concatenation
            string sentence = "";

            foreach (string str in myArray) 
            {
                sentence = sentence + " " +  str; // problem: memory waste every time a new string object is created
            }

            Console.WriteLine(sentence);

            //using StringBuilder class to deal with (mutable) strings
            StringBuilder stringBuilder = new StringBuilder();

            foreach(string str in myArray)
            {
                stringBuilder.Append(str);
                stringBuilder.Append(" ");
                Console.WriteLine(stringBuilder.ToString() + " , " +  stringBuilder.Length + " , " + stringBuilder.Capacity);
            }

            Console.WriteLine("\n" + stringBuilder.ToString());

            //properties and methods of the StringBuilder objects
            //characters can be read and set at a given index
            stringBuilder[0] = 'F';
            Console.Write(stringBuilder.ToString());

            //get the max capacity of the stringbuilder
            Console.WriteLine(stringBuilder.MaxCapacity);

            //insert new char in position and return a new stringbuilder object
            StringBuilder newString = stringBuilder.Insert(0, 'G');
            Console.WriteLine(newString.ToString());
            Console.WriteLine(stringBuilder.ToString());

            //remove from stringbuilder and return new stringbuilder object
            StringBuilder stringBuilder1 = stringBuilder.Remove(stringBuilder.ToString().IndexOf('q'), 5);
            Console.WriteLine(stringBuilder1.ToString());

            Console.WriteLine(stringBuilder.ToString());

            //replace from stringbuilder object and return new stringbuilder object
            StringBuilder stringBuilder2 = stringBuilder.Replace('q', 'r');
            Console.WriteLine(stringBuilder2.ToString());

            Console.ReadKey();
        }
    }
}
