/* Restrictions concerning the use of partial methods have been eliminated as starting from C# 9 
 * Previously: restrictions partial methods should have had only private access modifier, should not have returned other than void, and should not have supported the out parameter.
 * After(including) C# 9 :
 * partial methods can have any return type (including public or internal)
 * partial methods can return any type not only void
 * partial methods can use the out parameter 
 */


namespace UsingPartialMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            student.StudentId = 125;

            Console.WriteLine(student.StudentId);

            student.GetID();

            Console.ReadKey();
        }
    }
}
