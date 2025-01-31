using System.Linq.Expressions;

public class Program
{
    static void Main()
    {
        Expression<Func<int, int>> expression = a => a * a;

        //Compile the expression
        Func<int,int> func = expression.Compile();

        //Invoke the object obtain after compiling the expression
        int result = func.Invoke(25);

        Console.WriteLine(result);
        Console.ReadKey();
    }
}