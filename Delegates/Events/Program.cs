using Events;
using Extras;

namespace thisProgram
{
    public class Program
    {
        static void Main()
        {
            Subscriber s = new Subscriber();

            Publisher p = new Publisher();

            p.thisEvent += s.Add;

            p.RaiseEvent(40, 50);

            Console.ReadKey();

        }
    }
}