namespace DescribingTheThreadClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread myThread = Thread.CurrentThread;
            myThread.Name = "My Thread";

            Console.WriteLine("Hello from \"DescribingTheThreadClass\"");
            Console.WriteLine("\nName of the thread is : " + myThread.Name);
            Console.WriteLine("IsAlive: " + myThread.IsAlive);
            Console.WriteLine("IsBackground: " + myThread.IsBackground); // If false then the application does not terminate the execution until this thread is completed

            ThreadState theState = myThread.ThreadState;
            Console.WriteLine("\nThe state of this thread is: " + theState.ToString()); // Console.WriteLine() calls ToString() by default actually, but I am adding it explicitly

            ThreadPriority myPriority = myThread.Priority; // it is a get;set
            Console.WriteLine("\nThe thread priority is " + myPriority.ToString());

            Console.ReadKey();
        }
    }
}
