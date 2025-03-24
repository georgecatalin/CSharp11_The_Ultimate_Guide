using System.Net.Sockets;

namespace NestedRecordsAndImmutability
{
    public record Person(string Name, int Age, Address personAddress);
    public record Address(string? City)
    {
        public string? Country { get; set; } // mind that additionally to immutable properties, inside records one can also add mutable properties
    }




    internal class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person("George Calin", 46, new Address("Galati"));
            Person person2 = new Person("Mara Calin", 13, new Address("Braila"));

            Console.WriteLine("{0} - {1} - {2} ",person1.Name,person1.Age, person1.personAddress.City);
            Console.WriteLine("{0} - {1} - {2}", person2.Name, person2.Age, person2.personAddress.City);

            //person1.Age = 35; //Note that the records are reference types with immutable properties

            person1.personAddress.Country = "Romania";
            Console.WriteLine("The country of {0} is {1}.", person1.Name, person1.personAddress.Country);

            Console.ReadKey();
        }
    }
}
