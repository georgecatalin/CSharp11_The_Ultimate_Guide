using ActionLib;

public class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();

        publisher.thisEvent += (a, b) =>
        {
            int c = a + b;
            Console.WriteLine(c);
        };

        publisher.RaiseEvent(10,35);
        publisher.RaiseEvent(46,23);

        Console.ReadKey();
    }
}
