using ExtensionMethod;
using ExtensionMethods;
using System;

namespace Prg
{
    public class Program
    {
        static void Main()
        {
            Product p = new Product() { ProductCosting = 100, DiscountPercentage = 50 };
            Console.WriteLine(p.GetTotalDiscount());

            Console.ReadKey();
        }
    }
}