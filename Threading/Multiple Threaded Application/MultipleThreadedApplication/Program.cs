namespace MultipleThreadedApplication
{
    public class Counter
    {
        public void CountUp()
        {
            
            for (int i = 0; i < 100; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"i = {i.ToString()},");
            }
        }

        public void CountDown()
        {
            
            for (int i = 100; i >= 0; i--)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
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

            //invoking the Thread holding the CountUp() method
            ThreadStart threadStart_cup = new ThreadStart(counter.CountUp);
            Thread cup_thread = new Thread(threadStart_cup);

            cup_thread.Name = "Count-Up Thread";
            Console.WriteLine($"The status of {cup_thread.Name} is {cup_thread.ThreadState}.");

            cup_thread.Start();
            Console.WriteLine($"The status of {cup_thread.Name} is {cup_thread.ThreadState}.");

            //invoking the Thread holding the CountDown() method
            ThreadStart threadStart_cdown = new ThreadStart(counter.CountDown);
            Thread cdown_thread = new Thread(threadStart_cdown);

            cdown_thread.Name = "Count-Down Thread";
            Console.WriteLine($"The status of {cdown_thread.Name} is {cdown_thread.ThreadState}.");

            cdown_thread.Start();
            Console.WriteLine($"The status of {cdown_thread.Name} is {cdown_thread.ThreadState}.");

      

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("the execution of the thread has been completed => " + thisThread.Name);
            Console.ReadKey();
        }
    }
}
