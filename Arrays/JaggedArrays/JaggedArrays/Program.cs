using System;

namespace JaggedArrays
{
    public class Program
    {
        public static void Main()
        {
            //create a jagged array. A jagged array is an array of arrays, but each array can have a different dimension
            int[][] jaggedArray = new int[4][];

            jaggedArray[0] = new int[2] {10,20};
            jaggedArray[1] = new int[3] {30,40,50};
            jaggedArray[2] = new int[4] {60,70,80,90};
            jaggedArray[3] = new int[2] { 100, 110 };


            //display a jagged array
            Console.WriteLine("How to display a jagged array");
            Console.WriteLine();

            for(int i =0; i<4; i++)
            {
                for (int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.WriteLine(jaggedArray[i][j]);
                }

                Console.WriteLine();
            }
        }
    }
}