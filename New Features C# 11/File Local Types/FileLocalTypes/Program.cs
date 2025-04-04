/* Notes
 * 1. File Local Types can be used to access the types (classes, structs, interfaces, enums, delegates) only from inside the file where these types are declared
 * 2. File local types are used to avoid name collisions with types from another files and improve encapsulation and organizations
 * */

namespace FileLocalTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Service service = new Service();
           Console.WriteLine(service.GetData());
        }
    }
}
