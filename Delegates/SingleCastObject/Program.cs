using  DelegateLib;

namespace ThisProgram
{
    class Program
    {
        static void Main()
        {
            Sample c = new Sample();

            MyDelegateType thisDelegate;
            thisDelegate = new MyDelegateType(c.Add);

            int result;
            result = thisDelegate.Invoke(20, 10);

            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
