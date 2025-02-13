using System;
using NestedAnonymousLib;



namespace NestedAnonymousTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            
            var details = new { Age = person.GetAge(), Name = person.GetName(), Address = new { Street = "XYZ", City = "ABC" } };

            Console.WriteLine(details.Age);
            Console.WriteLine(details.Name);
            Console.WriteLine(details.Address.Street);
            Console.WriteLine(details.Address.City);

            Console.ReadKey();
        }
    }
}
