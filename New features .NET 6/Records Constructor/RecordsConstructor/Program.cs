/* There are two kinds of constructors associated with records:  compiler generated constructor (that initializes the immutable properties) and user-defined constructor which can be parameterized or parameterless */


namespace RecordsConstructor
{
    public record Person(string? Name, DateTime? DateOfBirth, int? Age)
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

    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("George Calin", DateTime.Parse("2011-09-13"));
            Console.WriteLine(person.ToString());
            Console.WriteLine(person); // there is no need to pass explicitely ToString() method cause Console.WriteLine() automatically adds it

            Console.WriteLine(person.GetName());

            Console.ReadKey();

        }
    }
}
