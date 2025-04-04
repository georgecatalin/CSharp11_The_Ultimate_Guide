/* Notes: list patterns have been added in C# 11 and are applicable for now on\ly to arrays and lists.
 * These allow validation of user input or database values
 * */


using System.Windows.Markup;

namespace ListPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 10, 25, 50 };

            // requirements: i wish to verify the following conditions at once
            // the array has only three elements
            // the first element is 10
            // the second element is less than 26
            // the last element is either 50 or 100

            //old way of doing
            bool isConditionOld = myArray.Length == 3 && myArray[0] == 10 && myArray[1] < 26 && (myArray[2] == 50 || myArray[2] == 100);
            Console.WriteLine("Verify the condition: " + isConditionOld);

            //new C# 11 way of doing
            bool isConditionNew = myArray is [10, < 26, 50 or 100]; // pattern matching for each element
            Console.WriteLine("Verify the condition: " + isConditionNew);

            Console.ReadKey();

        }
    }
}
