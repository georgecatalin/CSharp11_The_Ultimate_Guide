/* C# provides the ToString() method for records, and this can be overridden at will */

namespace RecordsToStringMethod
{
    public record Address(string City, string Country)
    {
        //supposedly we wish to override the ToString() method to show stuffs in a certain manner
        public override string ToString()
        {
            return $"The address is {City} in {Country}";
            
        }
    }
    public record Person(string Name, int Age, Address personAddress);



    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("George Calin", 46, new Address("Galati", "Romania"));
            Console.WriteLine(person.ToString()); // ToString() returns a string with the record and the properties and their values
            /* Person { Name = George Calin, Age = 46, personAddress = Address { City = Galati, Country = Romania } } if the ToString() is not overriden */

            Console.ReadKey();


      
        }
    }
}
