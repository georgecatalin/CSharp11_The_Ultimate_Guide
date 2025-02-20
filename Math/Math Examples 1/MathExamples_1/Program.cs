using System;

namespace MathExamples
{
    public class Program
    {
        public static void Main() 
        {
            double power = Math.Pow(10, 3);
            Console.WriteLine("Math.Power(10, 3)-> " + power);

            double min = Math.Min(20.34, 12.32);
            Console.WriteLine("Math.Min(20.34, 12.32) ->" + min);

            double max = Math.Max(20.34, 12.32);
            Console.WriteLine("Math.Max(20.34, 12.32) ->" + max);

            double floor = Math.Floor(23.3522); //23
            Console.WriteLine("Math.Floor(23.3522) ->" + floor);

            double ceiling = Math.Ceiling(23.3522); //24
            Console.WriteLine("Math.Ceiling(23.3522) ->" + ceiling);

            double rounddown = Math.Round(10.23); //10
            Console.WriteLine("Math.Round(10.23) ->" + rounddown);

            double roundup = Math.Round(10.56); //11
            Console.WriteLine("Math.Round(10.56) -> " + roundup);

            double rounddecimals = Math.Round(10.534567,3); //10.535
            Console.WriteLine("Math.Round(10.534567) -> " + rounddecimals);

            int sign_minus = Math.Sign(-24.67);
            int sign_positive = Math.Sign(26.89);
            int sign_zero = Math.Sign(0);

            int remainder;
            int quotient = Math.DivRem(10,3,out remainder);
            Console.WriteLine($"The quotient is {quotient} and the remainder {remainder} .");

            double root = Math.Sqrt(25.67);
            Console.WriteLine("The root is " + root);



            Console.WriteLine($"The signs are : {sign_minus} {sign_positive} {sign_zero} ");

            Console.ReadKey();
        }
    }
}
