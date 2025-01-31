using PredicateLib;

// Predicate is a special type of delegate, that unlike Func or Action , it requires only one parameter and return only boolean type

public class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();

        publisher.theEvent += (a) =>
        {
            return a >= 0;
        };

        Console.WriteLine(publisher.RaiseEvent(10));
        Console.WriteLine(publisher.RaiseEvent(-16));
        Console.WriteLine(publisher.RaiseEvent(780));

        Console.ReadKey();
    }
}