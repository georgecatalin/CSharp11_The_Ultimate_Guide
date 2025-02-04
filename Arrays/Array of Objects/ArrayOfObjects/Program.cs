using ClassLibrary;
using System;

namespace ArrayObjects
{
    public class Program
    {
        public static void Main()
        {
            Employee employee1  = new Employee() { EmpId=100, EmpName="George"};
            Employee employee2 = new Employee() { EmpId=101, EmpName="Calin"};

            Employee[] employees1 = new Employee[] { employee1, employee2 };

            foreach (Employee employee in employees1)
            {
                Console.WriteLine(employee.EmpId + ", "+ employee.EmpName);
            }


            Employee[] employees2 = new Employee[]
            {
                new Employee() {EmpId=200, EmpName ="Mara"},
                new Employee() {EmpId=201, EmpName="Sorina"},
                new Employee() {EmpId=202, EmpName="Vali"}
            };

            foreach (Employee employee in employees2)
            {
                Console.WriteLine(employee.EmpId + ", " + employee.EmpName);
            }

            Console.ReadKey();
        }
    }
}