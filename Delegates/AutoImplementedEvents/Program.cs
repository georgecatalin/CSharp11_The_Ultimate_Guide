using AutoImplemented;
using AutoImplementedEvents;

namespace thisProgram
{
    public class Program
    {
        static void Main()
        {
            Subscriber subscriber = new Subscriber();

            Publisher publisher = new Publisher();

            publisher.thisEvent += subscriber.Add;

            publisher.RaiseEvent(10, 20);
            publisher.RaiseEvent(20, 30);

            Console.ReadKey();
        }
    }
}
