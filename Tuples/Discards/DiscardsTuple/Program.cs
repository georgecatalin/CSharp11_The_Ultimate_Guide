using System;
using DiscardsLib;


namespace DiscardsTuple
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee();

            (int age,_, string Name) = employee.GetDetails(); // This is discarding a value from the tuple

            Console.WriteLine(age);
            Console.WriteLine(Name);
           
            Console.ReadKey();
        }
    }
}
