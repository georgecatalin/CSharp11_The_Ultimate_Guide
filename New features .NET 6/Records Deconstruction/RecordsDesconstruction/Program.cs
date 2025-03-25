/* C# provides out of the box a method for the deconstruction of records into a tuple of its properties */


using System.Net.Sockets;

namespace RecordsDesconstruction
{
    public record Person(string Name, int Age, Address personAddress);
 
    public record Address(string City, string Country);


    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("George Calin", 46, new Address("Galati", "Romania"));
            var (theName, theAge, theAddress) = person;

            Console.WriteLine("\nThe deconstruction of a record");
            Console.WriteLine($"{theName} {theAge} {theAddress.City} {theAddress.Country} ");

            //Deep deconstruction of the nested record
            var (theName1,theAge1,(theCity,theCountry)) = person;
            Console.WriteLine($"\n,{theName1},{theAge1}, {theCity} {theCountry}");

            Console.ReadKey();
        }
    }
}
