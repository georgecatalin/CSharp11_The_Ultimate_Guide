using System;



namespace TryCatchFinally
{
    internal class Program
    {
        static void Main()
        {
            try
            {
                int a, b;
                Console.WriteLine("Enter the first number :");
                string first = Console.ReadLine();

                a = int.Parse(first);

                Console.WriteLine("Enter the second number:");
                string second = Console.ReadLine();

                b = int.Parse(second);

                int c = a / b;
                Console.WriteLine("The division result is " + c);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}
