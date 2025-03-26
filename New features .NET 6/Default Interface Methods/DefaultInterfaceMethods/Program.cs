/* Previously, in prior versions of C# before C# 8.0 interfaces could only have abstract methods and properties. After C# 8 it is possible to use non-abstract, concrete methods 
 * with body in interfaces. Previously these were virtual methods
 * */

namespace DefaultInterfaceMethods
{
    public interface IEmployee
    {
        string Name { get; set; }

        //create a default method in the interface- it was called previously virtual method in abstract classes
        public string GetNameInUpper()
        {
            return Name.ToUpper();
        }
    }

    public class Manager : IEmployee
    {
        //implements the property of the interface
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }

    public class Accountant : IEmployee
    {
        //implements the property of the interface
        private string _name;
        public string Name
        {
            get => _name;
            set => _name = value;
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.Name = "George";

            Console.WriteLine("Printing from class property: "  + manager.Name);

            //Mind that , since the default method of the interface was not declared in the child class, it can only be invoked through an object of the interface type
            IEmployee imanager = (IEmployee)manager;
            Console.WriteLine("Printing from the default method of the interface: " + imanager.Name);

            Console.ReadKey();
        }
    }
}
