//we use the implementation of IComparer when we can not tap with the model class, and therefore we are adding the functionality in another class
//this is an example for sorting with two properties

using System;
using IComparerLib;

namespace Implement_IComparer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee() { EmployeeID = 9, EmployeeName = "George", EmployeeJob = "Engineer" },
                new Employee() { EmployeeID = 8, EmployeeName = "Mirel", EmployeeJob = "Designer" },
                new Employee() { EmployeeID = 10, EmployeeName = "Alex", EmployeeJob = "Singer" },
                new Employee() { EmployeeID = 6, EmployeeName = "Cornel", EmployeeJob = "Engineer" },
            };

            CustomComparer customComparer = new IComparerLib.CustomComparer();
            employees.Sort(customComparer);

            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee.EmployeeID + " " + employee.EmployeeName + " ," + employee.EmployeeJob);
            }

        }
            
    }
}
