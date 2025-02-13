using System;
using AnonymousLib;



namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            var details = new {Age = person.GetAge(), Name = person.GetName()};

            Console.WriteLine(details.Age + " " + details.Name);

            Console.ReadKey();
        }
    }
}
