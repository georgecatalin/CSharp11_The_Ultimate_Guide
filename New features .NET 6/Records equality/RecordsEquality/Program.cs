namespace RecordsEquality
{
    public record Person(string? Name, int Age);
    


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from RECORDS EQUALITY");

            Person person1 = new Person("George Calin", 46);
            Person person2 = new Person("George Calin", 46);

            Console.WriteLine(person1 == person2);// true C# OVERLOADS the == and != operators for value equality unlike for classes which are reference objects
            Console.WriteLine(person1.Equals(person2)); //true

            Console.ReadKey();

        }
    }
}
