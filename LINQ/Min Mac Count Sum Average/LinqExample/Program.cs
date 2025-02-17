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
                new Employee(){ EmployeeID =100, EmployeeName = "George", EmployeeJob = "Project Manager", Salary = 10200},
                new Employee(){ EmployeeID =200, EmployeeName = "Liviu", EmployeeJob = "Project Manager", Salary = 9800},
                new Employee(){ EmployeeID =300, EmployeeName = "Catalina", EmployeeJob = "Developer", Salary = 7003},
                new Employee(){ EmployeeID =400, EmployeeName = "Elena", EmployeeJob = "AI Engineer", Salary = 6000},
            };

            double minSalary = employees.Min(employee => employee.Salary); 
            double maxSalary = employees.Max(employee => employee.Salary);
            double averageSalary = employees.Average(employee => employee.Salary);
            double sumSalary = employees.Sum(employee => employee.Salary);
            int counter = employees.Count();

            Console.WriteLine(minSalary);
            Console.WriteLine(maxSalary);
            Console.WriteLine(averageSalary);
            Console.WriteLine(sumSalary);
            Console.WriteLine(counter);


            Console.ReadKey();
        }
    }
}
