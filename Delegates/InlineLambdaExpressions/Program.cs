using InlineLambda;

public class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();

        publisher.thisEvent += (a, b) => a + b; //we use lambda expressions for single line operations, conditions or applying another method

        Console.WriteLine(publisher.RaiseEvent(25, 67));
        Console.WriteLine(publisher.RaiseEvent(40, 20));

        Console.ReadKey();


    }
}