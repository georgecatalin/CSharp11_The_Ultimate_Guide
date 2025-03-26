/* **
 * In the older versions of C# both properties and methods in interfaces had the access modifier as 'public' even this was not specified explicitly
 * In the newer versions of C# the abstract methods of the interfaces can also have different access modifiers than public
 * */


namespace InterfaceMethodsAccessModifiers
{
    public interface IEmployee
    {
        public string Name { get; set; }

        internal string GetNameInLower();
        internal string GetNameInUpper();

    }

    public class Employee : IEmployee
    {
        public string Name { get; set; }

        //there are two options of implementing non-public abstract methods in child classes inheriting from interfaces: 1. using explicit implementation 2. converting to 'public'
        string IEmployee.GetNameInLower()
        {
            return Name.ToLower();
        }

        public string GetNameInUpper()
        {
            return Name.ToUpper();
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.Name = "Test";

            Console.WriteLine( "option 2 - converting the non-public access modifier to public: " + employee.GetNameInUpper());

            IEmployee iemployee = (IEmployee)employee;
            Console.WriteLine("option 1 - explicitly calling the interface method: "  + iemployee.GetNameInLower());

            Console.ReadKey();

        }
    }
}
