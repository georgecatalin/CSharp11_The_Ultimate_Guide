using DeepCopyClassLib;
using System;

namespace DeepCopy
{
    public class Program
    {
        public static void Main()
        {
            //Create the initial array
            Employee employee1 = new Employee() { Name = "George", Role = "Engineer" };
            Employee employee2 = new Employee() { Name = "Mara", Role = "Manager" };
            Employee employee3 = new Employee() { Name = "Sorina", Role = "Accountant" };

            Employee[] thisArray = new Employee[] {employee1, employee2, employee3};

            //Display the initial array
            Console.WriteLine();
            Console.WriteLine("the initial array is ");

            foreach (Employee emp in thisArray) Console.WriteLine(emp.Name + " , " + emp.Role);


            //Perform the deep copy
            Employee[] employee_deepcopy = new Employee[thisArray.Length];

            for(int i=0; i<employee_deepcopy.Length; i++)
            {
                employee_deepcopy[i] =(Employee) thisArray[i].Clone();
            }

            //Prove there is a deep copy and each object in the new array is other object than the ones in the first array
            thisArray[1].Name = "Sorin";

            //Display the new array
            Console.WriteLine();
            Console.WriteLine("the deep copy  array is ");

            foreach(var emp in employee_deepcopy) Console.WriteLine(emp.Name + " , " + emp.Role);


            //Display the initial array
            Console.WriteLine();
            Console.WriteLine("the initial array is NOW ");

            foreach (Employee emp in thisArray) Console.WriteLine(emp.Name + " , " + emp.Role);

            Console.ReadKey();
        }
    }
}