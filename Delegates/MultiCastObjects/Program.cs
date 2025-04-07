using MultiCast;

namespace thisProgram
{
    public class Program
    {
        static void Main()
        {
            Sample s = new Sample();

            MultiCastDelegate thisDelegate;

            thisDelegate = s.Add;

            thisDelegate += s.Multiply;

            thisDelegate.Invoke(20, 30);

            Console.ReadKey();

        }
    }
}
