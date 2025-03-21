/* Records are shortened manners to create reference-types that hold immutable properties */

namespace RecordsBasics
{
    public record Person(string Name, int Age);


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from RECORDS BASICS");


            Person person1 = new Person("George Calin", 46);
            Person person2 = new("Mara Calin", 14); // how to appeal the constructor of the record using the new() expression

            //the immutable properties of the record Person can only by initialized through the constructor, but these can not be modified at a later time
            Console.WriteLine("{0}-{1}",person1.Name,person1.Age);
            Console.WriteLine("{0}-{1}", person2.Name, person2.Age);

            //but once the property is initialized , it can not longer be changed
            //person1.Age = 47;

            Console.ReadKey();
        }
    }
}
