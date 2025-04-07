using Anonymous;

namespace thisProgram
{
    public class Program
    {
        static void Main()
        {
            Publisher publisher = new Publisher();

            publisher.thisEvent += delegate (int a, int b)
            {
                int c = 0;
                c = a + b;
                Console.WriteLine(c);
            };

            publisher.RaiseEvent(10, 40);
            publisher.RaiseEvent(20, 70);

            Console.ReadKey();
        }
    }
}
