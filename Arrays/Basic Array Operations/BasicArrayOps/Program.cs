using System;

namespace thisProgram
{
    public class Program
    {
        public static void Main()
        {
            int[] array1 = new int[5] { 1, 2, 4, 5, 6 };
            string[] array2 = new string[] { "George", "Calin", "Catalin", "Mara", "Sorina" };

            Console.WriteLine();
            Console.WriteLine(array1[0]);
            Console.WriteLine(array1[1]);
            Console.WriteLine(array1[2]);
            Console.WriteLine(array1[3]);
            Console.WriteLine(array1[4]);

            Console.WriteLine();

            for(int i =0; i<array1.Length; i++)
            {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine();

            for(int i=array1.Length-1;i>=0;i--)
            {
                Console.WriteLine(array1[i]);
            }

            Console.WriteLine();


            foreach(int i in array1)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine(array2[0]);
            Console.WriteLine(array2[1]);
            Console.WriteLine(array2[2]);
            Console.WriteLine(array2[3]);
            Console.WriteLine(array2[4]);

            Console.WriteLine();

            for(int i=0;i<array2.Length;i++)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine();

            for(int i=array2.Length-1; i>=0; i--)
            {
                Console.WriteLine(array2[i]);
            }

            Console.WriteLine();

            foreach(string a in array2)
            {
                Console.WriteLine(a);
            }

        }
    }
}