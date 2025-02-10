using System;
using ManyToOneClass;

namespace ManyToOne
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //create an employee object
           Employee employee = new Employee();
            employee.EmployeeName = "George";
            employee.EmployeeID = 100;

            Employee employee2 = new Employee();
            employee2.EmployeeName = "Sorin";
            employee2.EmployeeID = 101;

            Employee employee3 = new Employee();
            employee3.EmployeeName = "Raul";
            employee3.EmployeeID = 102;

           //create a department object
           Department department = new Department();
            department.Name = "Accounting";
            department.Code = 1;

            employee.Department = department;
            employee2.Department = department;
            employee3.Department = department;

            //display
            Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.Department.Name + " " + employee.Department.Code);
            Console.WriteLine(employee2.EmployeeName + " " + employee2.EmployeeID + " " + employee2.Department.Name + " " + employee2.Department.Code);
            Console.WriteLine(employee3.EmployeeName + " " + employee3.EmployeeID + " " + employee3.Department.Name + " " + employee3.Department.Code);

        }
    }
}
