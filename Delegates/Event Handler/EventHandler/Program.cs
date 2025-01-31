/* We use Event Handlers only when working with predefined events that is Windows Forms, WPF and ASP.NET WebForms
 * We are not using Event Handlers when working with ASP.NET MVC and ASP.NET Core */

using EventHandlerLib;

public class Program
{
    static void Main()
    {
        Program program = new Program();
        program.DoWork();

        Console.ReadKey();
    }

    private void DoWork()
    {
        Publisher publisher = new Publisher();

        publisher.thisEvent += (sender, e) =>
        {
            int c = e.a + e.b;
            Console.WriteLine(c);
        };

        publisher.RaiseEvent(this, 10, 20);
        publisher.RaiseEvent(this, 45, 56);
    }
}