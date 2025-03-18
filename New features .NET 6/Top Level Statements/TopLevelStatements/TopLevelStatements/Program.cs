// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
string myName = "George Calin";
Console.WriteLine("My name is {0}.", myName);
Console.ReadKey();

a_namespace.Sample.Main();

namespace a_namespace
{
    internal class Sample
    {
      public static void Main()
        {
            Console.WriteLine("Hi from the class");
        }
    }
}