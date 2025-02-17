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
                new Employee(){ EmployeeID =200, EmployeeName = "Paul", EmployeeJob = "Project Manager", Salary = 1220},
                new Employee(){ EmployeeID =300, EmployeeName = "Catalina", EmployeeJob = "Developer", Salary = 890},
                new Employee(){ EmployeeID =400, EmployeeName = "Elena", EmployeeJob = "AI Engineer", Salary = 980},
            };

            //there are three elements in the list with the Job as "Project Manager" 
            Console.WriteLine("\n Using .First()");
            Employee employee = employees.First(employee => employee.EmployeeJob == "Project Manager");
            Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.EmployeeJob);

            /*
            Employee employee1 = employees.First(employee => employee.EmployeeJob == "Karateka"); //returns exception cause there is no match
            Console.WriteLine(employee.EmployeeName + " " + employee.EmployeeID + " " + employee.EmployeeJob);
            */


            Console.WriteLine("\n Using .FirstOrDefault()");
            Employee? employee3 = employees.FirstOrDefault(employee => employee.EmployeeJob == "Project Manager");
            if (employee3 != null)
            {
                Console.WriteLine(employee3.EmployeeName + " " + employee3.EmployeeID + " " + employee3.EmployeeJob);
            }
            else
            {
                Console.WriteLine("No match has been found");
            }

            Console.WriteLine("\n Using .Last()");
            Employee lastMatching = employees.Last(employee => employee.EmployeeJob == "Project Manager");
            Console.WriteLine(lastMatching.EmployeeName + " " + lastMatching.EmployeeID + " " + lastMatching.EmployeeJob);

            //returns exception when no match is found
            /*
            Employee lastMatching2 = employees.Last(employee => employee.EmployeeJob == "Karateka");
            Console.WriteLine(lastMatching2.EmployeeName + " " + lastMatching2.EmployeeID + " " + lastMatching2.EmployeeJob);
            */

            Console.WriteLine("\n Using .LastOrDefault()");
            Employee? lastMatching1 = employees.Last(employee => employee.EmployeeJob == "Project Manager"); // returns null in case if no match is found
            if (lastMatching1 != null)
            {
                Console.WriteLine(lastMatching1.EmployeeName + " " + lastMatching1.EmployeeID + " " + lastMatching1.EmployeeJob);
            }
            else
            {
                Console.WriteLine("No match was found for LastOrDefault()");
            }

            // an example for ElementAt() and ElementAtOrDefault()
            Employee elementAt = employees.Where(employee => employee.EmployeeJob == "Project Manager").ElementAt(1);
            Console.WriteLine(elementAt.EmployeeName + " " + elementAt.EmployeeID + " " + elementAt.EmployeeJob);


            //throws an exception if no element is found at the given position
            //Employee elementAt4 = employees.Where(employee => employee.EmployeeJob == "Project Manager").ElementAt(4);
            //Console.WriteLine(elementAt4.EmployeeName + " " + elementAt4.EmployeeID + " " + elementAt4.EmployeeJob);

            // Protects from exception using ElementAtOrDefault()
            Employee? elementAt5 = employees.Where(employee => employee.EmployeeJob == "Project Manager").ElementAtOrDefault(5);
            if (elementAt5 != null)
            {
                Console.WriteLine(elementAt5.EmployeeName + " " + elementAt5.EmployeeID + " " + elementAt5.EmployeeJob);
            }
            else
            {
                Console.WriteLine("No element match found at index 5");
            }

            // an example with Single() and SingleOrDefault()
            Employee singleEmployee = employees.Single(employee => employee.EmployeeJob == "Developer");
            Console.WriteLine(singleEmployee.EmployeeName + " " + singleEmployee.EmployeeID + " " + singleEmployee.EmployeeJob);

            // throws an exception if more than one match is found or no match is found
            /*
            Employee singleEmployeeException = employees.Single(employee => employee.EmployeeJob == "Project Manager");
            Console.WriteLine(singleEmployeeException.EmployeeName + " " + singleEmployeeException.EmployeeID + " " + singleEmployeeException.EmployeeJob);
            */

            // protects from exception in case that no match is found, still throws an exception if multiple matches found
            Employee? singleEmployeeDefault = employees.SingleOrDefault(employee => employee.EmployeeJob == "Karateka");
            if (singleEmployeeDefault != null)
            {
                Console.WriteLine(singleEmployee.EmployeeName + " " + singleEmployee.EmployeeID + " " + singleEmployee.EmployeeJob);
            }
            else
            {
                Console.WriteLine("Not a single match has been found.");
            }

                Console.ReadKey();
        }
    }
}
