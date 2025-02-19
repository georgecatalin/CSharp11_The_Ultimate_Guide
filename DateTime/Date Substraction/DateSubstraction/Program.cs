using System;
using DateSubstractionLib;


namespace DateSubstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee() { EmployeeName = "George", DateOfJoining = DateTime.Parse("2024-02-14") };

            DateTime today = DateTime.Now;

            if(today.CompareTo(employee.DateOfJoining) >  0)
            {
                TimeSpan timespan1 = today - employee.DateOfJoining;
                TimeSpan timespan2 = today.Subtract(employee.DateOfJoining);

                employee.Experience = timespan2.TotalDays / 365;
                double experienceInMonths = (employee.Experience - Convert.ToInt32(employee.Experience))/30;
                Console.WriteLine("The rest of months in experience is " + Math.Floor(experienceInMonths));
            }
            else
            {
                Console.WriteLine("The date of Joining is after today.This is not correct.");
            }


            Console.WriteLine("Employee experience in years is " + employee.Experience);

            Console.ReadKey();
        }
    }
}
