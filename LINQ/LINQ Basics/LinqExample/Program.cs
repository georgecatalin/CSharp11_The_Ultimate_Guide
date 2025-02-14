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



            IEnumerable<Employee> employeesExtracted = employees.Where(employee => employee.EmployeeJob == "Project Manager");

            foreach (Employee employee in employeesExtracted)
            {
                Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.City);
            }

            Console.ReadKey();
        }
    }
}
