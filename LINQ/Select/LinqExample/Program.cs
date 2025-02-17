using LINQLib;
using System;
using System.Collections;
using System.Linq;



namespace LinqExample
{
    internal class Program
    {
        static void Main()
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee(){ EmployeeID =100, EmployeeName = "George", EmployeeJob = "Project Manager", City = "Galati"},
                new Employee(){ EmployeeID =200, EmployeeName = "Liviu", EmployeeJob = "Project Manager", City = "Galati"},
                new Employee(){ EmployeeID =300, EmployeeName = "Catalina", EmployeeJob = "Developer", City = "Braila"},
                new Employee(){ EmployeeID =400, EmployeeName = "Elena", EmployeeJob = "AI Engineer", City = "Galati"},
            };

            IEnumerable<int> ints = employees.Select(employee => 1978);

            foreach (int i in ints) Console.WriteLine(i);

            IEnumerable<Person> persons = employees.Select(employee => new Person() { PersonName = employee.EmployeeName });

            foreach (var item in persons)
            {
                Console.WriteLine(item.PersonName);
            }

           

            Console.ReadKey();
        }
    }
}
