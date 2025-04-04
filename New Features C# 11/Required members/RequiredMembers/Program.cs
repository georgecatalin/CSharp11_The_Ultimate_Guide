/* Notes:
 * 1. Required members are newly introduced in C# 11 to ease against null checking and protect against runtime errors
 * 2. Required members are properties or fields that have to be initialized either in the parameterless or parameterized constructor or in the object initializer otherwise there is a compiler error
 * 3. When initializing the required member in the constructor this has to be decorated with a decorator      [SetsRequiredMembers] to let the compiler know that the members is initialized in that constructor
 * */


namespace RequiredMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Name = "Test" };

            Console.WriteLine(person.Name);

            Person person2 = new Person();
            Console.WriteLine(person2.Name);

        }
    }
}
