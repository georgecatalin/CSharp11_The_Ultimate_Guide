using FuncLib;

public class Program
{
    static void Main()
    {
        Publisher publisher = new Publisher();

        publisher.thisEvent += (a, b) => a + b;

        Console.WriteLine(publisher.RaiseEvent(10, 20));
        Console.WriteLine(publisher.RaiseEvent(25, 60));

        Console.ReadKey();
    }
}