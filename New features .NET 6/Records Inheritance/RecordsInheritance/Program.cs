/* A record can inherit from other records
 * A record can not inherit from a class
 * A class can not inherit from a record
 * A record can inherit from one or more interfaces
 * A record can be marked with abstract or sealed 
 * */


namespace RecordsInheritance
{

    public interface IPerson
    {
        public string? Name { get; init; }
    }

    /// <summary>
    /// This is an example of implementing inheritance from an interface with a record
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="DateOfBirth"></param>
    /// <param name="Age"></param>
    public record Person(string? Name, DateTime? DateOfBirth, int? Age) : IPerson
    {
        /// <summary>
        /// This is a parameterized user-defined constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="dateOfBirth"></param>
        public Person(string? name, DateTime? dateOfBirth) : this(name, dateOfBirth, null)
        {
            if (dateOfBirth is not null)
            {
                Age = Convert.ToInt32(DateTime.Now.Subtract(dateOfBirth.Value).TotalDays / 365.25);
            }
        }
        /// <summary>
        /// This is a parameterless constructor
        /// </summary>
        public Person() : this(null, null, null)
        {

        }

        /// <summary>
        /// This is a method inside the record. Records have to host a limited number of methods 1-2 methods unlike classes which can hold any number of methods
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {

            return Name ?? " ";
        }
    }

    /// <summary>
    /// Inheriting from a record with full compiler generated constructor in the base record
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="DateOfBirth"></param>
    /// <param name="Age"></param>
    /// <param name="salary"></param>
    public record Employee(string? Name, DateTime? DateOfBirth, int? Age, double? salary) : Person(Name,DateOfBirth,Age);

    /// <summary>
    /// Inheriting from a record but using the user-generated constructor in the base record
    /// </summary>
    /// <param name="Name"></param>
    /// <param name="DateOfBirth"></param>
    /// <param name="salary"></param>
    public record Manager(string? Name, DateTime? DateOfBirth, double? salary):Person(Name, DateOfBirth);

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("George Calin", DateTime.Parse("2011-09-13"));
            Console.WriteLine(person.ToString());
            Console.WriteLine(person); // there is no need to pass explicitely ToString() method cause Console.WriteLine() automatically adds it

            Console.WriteLine(person.GetName());
            Console.WriteLine();    

            Employee employee1 = new Employee("Mara Calin", DateTime.Parse("2011-09-11"), 14, 2000.45);
            Console.WriteLine(employee1.ToString());
            Console.WriteLine();

            Manager manager = new Manager("Sorina Burssen", DateTime.Parse("1977-07-08"), 5600.34);
            Console.WriteLine(manager.ToString());
            Console.WriteLine() ;





            Console.ReadKey();

        }
    }
}
