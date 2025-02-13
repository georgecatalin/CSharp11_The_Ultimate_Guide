using System;
using ValueTuplesLib;


namespace ValueTuples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();


            (int age, string name, string role) details = employee.GetEmployeeDetails();

            Console.WriteLine(details.age);
            Console.WriteLine(details.name);
            Console.WriteLine(details.role);

            Console.ReadKey();
        }
    }
}
