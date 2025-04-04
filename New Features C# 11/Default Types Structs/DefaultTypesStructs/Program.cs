/* Notes:
 * C# 11 provides by default a constructor for structs which sets the default values into fields, based on their individual types
 */

namespace DefaultTypesStructs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point = new Point();

            Console.WriteLine(point.Name); // null
            Console.WriteLine(point.x); // 0 is default value for int
            Console.WriteLine(point.y); // 0 is default value for int

            Console.ReadKey();
        }
    }
}
