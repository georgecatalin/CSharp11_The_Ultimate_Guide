namespace MainThread
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from MainThread");
            Thread thisCurrentThread = Thread.CurrentThread;
            //naming the thread 
            thisCurrentThread.Name = "My Main Thread";
            Console.WriteLine("this is the current thread: " + thisCurrentThread + "\t->\t " + " \"" + thisCurrentThread.Name + "\"");

            method1(); //method1() is also executing in the same main thread , on the same core as it is appealed by the main()

            Console.ReadKey();
        }

        static void method1()
        {
            Console.WriteLine("\nmethod1() is also executing in the same main thread , on the same core as it is appealed by the main()");
        }
    }
}
