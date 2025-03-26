/* It is possible to use private interface methods, but only with default methods (that have a body implementation)
 * it makes no sense to use private abstract interface methods, as these could not ne inherited and herein implemented in the child classes */

namespace InterfacePrivateMethods
{
    public interface IEmployee
    {
        string Name { get; set; }
        public static string GetGreeting()
        {
            return "Mr/Mrs";
        }

        //the private non-abstract methods can be used in other non-abstract methods of the interface
        public string GetName()
        {
            return IEmployee.GetGreeting() + " " + Name; //use the static interface method from inside the interface
        }

    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }

    }



    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Test";

            IEmployee iemployee = (IEmployee) employee;
            Console.WriteLine(iemployee.GetName());
            Console.WriteLine("\nuse the static interface method from outside the interface");
            Console.WriteLine(IEmployee.GetGreeting()); // use the static interface method from outside the interface

            Console.ReadKey();
        }
    }
}
