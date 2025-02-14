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
                new Employee(){ EmployeeID =100, EmployeeName = "George", EmployeeJob = "Project Manager", Salary = 1277},
                new Employee(){ EmployeeID =200, EmployeeName = "Liviu", EmployeeJob = "Project Manager", Salary = 1250},
                new Employee(){ EmployeeID =300, EmployeeName = "Catalina", EmployeeJob = "Developer", Salary = 890},
                new Employee(){ EmployeeID =400, EmployeeName = "Elena", EmployeeJob = "AI Engineer", Salary = 980},
            };

            Console.WriteLine("\nIOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(employee => employee.EmployeeID);");

            IOrderedEnumerable<Employee> sortedEmployees = employees.OrderBy(employee => employee.EmployeeID);
           
            foreach (Employee employee in sortedEmployees)
            {
                Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.Salary);
            }

            Console.WriteLine("\n IOrderedEnumerable<Employee> sortedEmployees1 = employees.OrderByDescending(employee => employee.EmployeeID);");

            IOrderedEnumerable<Employee> sortedEmployees1 = employees.OrderByDescending(employee => employee.EmployeeID);

            foreach (Employee employee in sortedEmployees1)
            {
                Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.Salary);
            }

            Console.WriteLine("\nIOrderedEnumerable<Employee> doubleSortedEmployees = employees.OrderBy(employee => employee.EmployeeJob).ThenBy(employee => employee.Salary);");
            IOrderedEnumerable<Employee> doubleSortedEmployees = employees.OrderBy(employee => employee.EmployeeJob)
                .ThenBy(employee => employee.Salary);

            foreach (Employee employee in doubleSortedEmployees) Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.Salary);

            Console.WriteLine("\nIOrderedEnumerable<Employee> doubleSortedEmployeesDesc = employees.OrderByDescending(employee => employee.EmployeeJob).ThenByDescending(employee => employee.Salary);");

            IOrderedEnumerable<Employee> doubleSortedEmployeesDesc = employees.OrderByDescending(employee => employee.EmployeeJob)
                .ThenByDescending(employee => employee.Salary);

            foreach (Employee employee in doubleSortedEmployeesDesc) Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.Salary);

            Console.ReadKey();
        }
    }
}
