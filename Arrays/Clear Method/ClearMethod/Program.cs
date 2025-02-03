using System;

namespace ClearMethod
{
    public class Program
    {
        public static void Main(string[] args)
        {
            double[] doubles = new double[] { 10, 20, 30, 40, 50, 60, 70 };

            Console.WriteLine();
            Console.WriteLine("the initial array is");

            foreach(var a in doubles) Console.WriteLine(a);

            Console.WriteLine();

            Array.Clear(doubles,2,3);
            Console.WriteLine("After clearing, the array is ");

            foreach (var a in doubles) Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
