/* Expression Body Members is a new way of writing shorter code in C# introduced in C# 7.0
 * At compile time, the content of the method is taken as the longer version */
using ExpressionBodyClass;

public class Program
{
    static void Main()
    {
        Student s = new Student("George");

        Console.WriteLine(s.StudentName);
        Console.WriteLine(s.GetNameLength());

        Console.ReadKey();
    }
}

