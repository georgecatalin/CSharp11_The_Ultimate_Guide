using Lambda;

namespace thisProgram
{
    public class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();

            publisher.thisEvent += (a, b) =>
            {
                int c = a + b;
                return c;
            };

            Console.WriteLine(publisher.RaiseEvent(10, 30));
            Console.WriteLine(publisher.RaiseEvent(20, 50));

            Console.ReadKey();
        }
    }
}
