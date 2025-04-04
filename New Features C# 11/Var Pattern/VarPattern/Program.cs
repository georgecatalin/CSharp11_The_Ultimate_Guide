/* Notes:
 * 1. The var pattern can be used to extract values from a list or array
 * 2. The var pattern can be used with list pattern, tuples and records which have a deconstruct method themselves into tuples
 * **/

using System.Security.Cryptography.X509Certificates;

namespace VarPattern
{

    public record Person(string FirstName, string LastName, int Age);
    internal class Program
    {

        static void Main(string[] args)
        {
            {
                //potential usage example: verify if the second element of the list is less than the third with pattern matching
                //note that the variables b and c are treated as local variables defined outside the Console.WriteLine() for this purpose we introduce the curly braces for limiting the block of code span life of local variable
                //var b, var c
                Console.WriteLine(new List<int> { 10,25,50} is [10, var b, var c] && ( b<c )); //true

            }

            {
                // var pattern can be used simultaneusly with pattern matching
                Console.WriteLine(new List<int>() { 10, 25, 50 } is [10, var b and <= 26, var c] && (b < c));//true

                //use of var pattern with Records objects that have a deconstruct() method in the CLR
                Person person = new Person("Mara", "Calin", 14);
                Console.WriteLine(person is ("Mara", "Calin", > 10)); // pattern matching with records  reminder

                {
                    Console.WriteLine(person is ("Mara", "Calin", > 10) and var (firstName, lastName, age) && (firstName != lastName)); // pattern matching deconstructing a record into a tuple -> True
                }

                {
                    Console.WriteLine(person is ("Mara", "Mara", > 10) and var (firstName, lastName, age) && (firstName != lastName)); // false
                }

            }

        }
    }
}
