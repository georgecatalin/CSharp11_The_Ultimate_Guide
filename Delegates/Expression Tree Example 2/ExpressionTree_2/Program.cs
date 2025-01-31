using ExpressionTree;
using System.Linq.Expressions;


public class Program
{
    static void Main()
    {

        Student s = new Student() { StudentAge=18, StudentId=125, StudentName="George Calin"};

        Expression<Func<Student, bool>> expression = s => s.StudentAge >= 12 && s.StudentAge <= 20;

        //compile
        Func<Student, bool> func = expression.Compile();

        //invoke
        bool isTeenager = func.Invoke(s);

        Console.WriteLine(isTeenager);

        Console.ReadKey();
    }
}