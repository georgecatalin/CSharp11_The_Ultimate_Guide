using System;

namespace MultidimensionalArrays
{
    public class Program
    {
        public static void Main()
        {
            //create multidimensional array . a multidimensional array is an array of arrays holding the same dimensions
            int[,] a = new int[3, 2]
            {
                {10,20 },
                {30,40 },
                {50,60 }
            };


            //displaying the multidimensional array
            for(int i=0; i<3; i++)
            {
                for(int j=0;j<2;j++)
                {
                    Console.WriteLine(a[i, j]);
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}