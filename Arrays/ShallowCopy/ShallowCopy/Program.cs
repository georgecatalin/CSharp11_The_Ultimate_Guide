using System;
using Microsoft.VisualBasic;
using ShallowClass;

namespace ShallowCopy
{
    public class Program
    {
        public static void Main()
        {
            //create an array of objects
            Employee[] myArray = new Employee[]
            {
                new Employee() {Name="George", Role="Developer"},
                new Employee() {Name="Mara", Role="Designer"},
                new Employee() {Name="Sorina", Role="Analyst"}
            };


            //print the contents of the initial array
            Console.WriteLine();
            Console.WriteLine("The initial array contents ");

            foreach (Employee emp in myArray) Console.WriteLine(emp.Name+" , " + emp.Role);


            //use CopyTo() method to perform a shallow copy of the existing array into another previously created array
            Employee[] myArray2 = new Employee[5];

            myArray.CopyTo(myArray2, 0);


            Console.WriteLine("Array copied with CopyTo()");
            //print the contents of the newly created and filled in array
            foreach(Employee emp in myArray2)
            {
                if(!(emp is null))
                {
                    Console.WriteLine(emp.Name + " " + emp.Role);
                }
                else
                {
                    Console.WriteLine("Null object");
                }
            }
                
                

            Console.WriteLine();

            //Use Clone() to perform another shallow copy of the reference variables pointing to the arrays in the heap

            Employee[] myArray3 =(Employee[]) myArray.Clone();

            //demonstration of the shallow copy fact => the arrays contain references to the objects , and not the objects themselves
            myArray[0].Role = "Karateka";

            //print the content of the array
            Console.WriteLine("Array copied with Clone()");
            foreach (var emp in myArray3)
                if (!(emp is null))
                {
                    Console.WriteLine(emp.Name + " " + emp.Role);
                }
                else
                {
                    Console.WriteLine("Null object");
                }

            Console.ReadKey();
        }
    }
}
