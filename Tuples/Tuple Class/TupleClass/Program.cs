using System;
using TupleClassLib;



namespace TupleClass
{
    internal class Program
    {
        static void Main()
        {
            Details details = new Details();

            Console.WriteLine(details.GetDetails().Item1); // here is the first property of the tuple
            Console.WriteLine(details.GetDetails().Item2); // here is the second property of the tuple

            Console.ReadKey();
        }
    }
}
