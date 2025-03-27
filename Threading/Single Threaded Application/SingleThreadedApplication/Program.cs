namespace SingleThreadedApplication
{
    public class Counter
    {
        public void CountUp()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 100; i++)
            {
               
                Console.WriteLine($"i = {i.ToString()},");
            }
        }

        public void CountDown()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            for (int i = 100; i >= 0; i--)
            {
                Console.WriteLine($"i = {i.ToString()},");
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from \"SingleThreadedApplication\" ");


            Thread thisThread = Thread.CurrentThread;
            thisThread.Name = "my thread";
            Console.WriteLine("\nName of the thread is: " + thisThread.Name);

            Counter counter = new Counter();
            counter.CountUp();
            counter.CountDown();

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("the execution of the thread has been completed => " + thisThread.Name);
            Console.ReadKey();
        }
    }
}
