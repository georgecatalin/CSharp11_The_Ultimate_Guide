using DeconstructingLib;


namespace DeconstructingTuples
{
    internal class Program
    {
        static void Main()
        {
            Employee employee = new Employee();

            (int Age, string Name, string Role) = employee.GetDetails();  //this is deconstructing a tuple

            Console.WriteLine(Age);
            Console.WriteLine(Name);
            Console.WriteLine(Role);

            Console.ReadKey();
        }
    }
}
