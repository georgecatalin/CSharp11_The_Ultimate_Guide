/* One way to pass parameters to threads is by using lambda expressions with the delegate ThreadStart()*/

namespace MultipleThreadedApplication
{
    public class Counter
    {
        public void CountUp(object? count)
        {
            try
            {
                Console.WriteLine("Count-up Thread has started");
                Thread.Sleep(1000);

                int? maxCount = (int?)count; // since the parameter is passed as an object? , it has to be typecasted. ParameterizedThreadStart supports only object? for the sake of universality

                for (int i = 0; i < maxCount; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"i = {i.ToString()},");
                    Thread.Sleep(100); // the thread stops execution for 1000 milliseconds = 1 second and control jumps to the other thread -> thread goes to status 'WaitSleepJoin'
                }

                Console.WriteLine("Count-up Thread has completed");
                Thread.Sleep(1000);
            }
            catch (ThreadInterruptedException ex)
            {
                Console.WriteLine("Count-up Thread has been interrupted.");
            }
        }

        public void CountDown(object? count)
        {
         
   
                Console.WriteLine("Count-down Thread has started");
                Thread.Sleep(1000);

                int? maxCount = (int?) count; // since the parameter is passed as an object? , it has to be typecasted. ParameterizedThreadStart supports only object? for the sake of universality
            for (int? i = maxCount; i >= 0; i--)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"j = {i.ToString()},");
                    Thread.Sleep(100); // the thread stops execution for 1000 milliseconds = 1 second and control jumps to the other thread ->  thread goes to status 'WaitSleepJoin'
                }

                Console.WriteLine("Count-down Thread has completed");
                Thread.Sleep(1000);
            
     
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello from \"SingleThreadedApplication\" ");


            Thread thisThread = Thread.CurrentThread;
            thisThread.Name = "my thread";
            Console.WriteLine("\n" +  thisThread.Name + " has just started ...");

            Counter counter = new Counter();

            // There is a way to pass parameters when creating the thread using ParameterizedThreadStart
            ParameterizedThreadStart threadStart_cup = new ParameterizedThreadStart(counter.CountUp);

            Thread cup_thread = new Thread(threadStart_cup) { Name = "Count-Up Thread", Priority = ThreadPriority.BelowNormal }; //initialization is done with object initializer instead separately

            // At the time of its generation by the OS, each thread gets a unique id for its lifetime, and this is available as a get withManagedThreadId property
            Console.WriteLine($"The status of {cup_thread.Name} ({cup_thread.ManagedThreadId}) is {cup_thread.ThreadState}.");

            cup_thread.Start(100); // the argument of the method is passed within the Start() method
            Console.WriteLine($"The status of {cup_thread.Name} is {cup_thread.ThreadState}.");

            // There is a way to pass parameters when creating the thread using ParameterizedThreadStart
            ParameterizedThreadStart threadStart_cdown = new ParameterizedThreadStart(counter.CountDown);
            Thread cdown_thread = new Thread(threadStart_cdown) { Name= "Count-Down Thread" , Priority = ThreadPriority.AboveNormal}; //initialization is done with object initializer instead separately

          
            Console.WriteLine($"The status of {cdown_thread.Name} ({cdown_thread.ManagedThreadId}) is {cdown_thread.ThreadState}.");

            cdown_thread.Start(100); // the argument of the method is passed within the Start() method
            Console.WriteLine($"The status of {cdown_thread.Name} is {cdown_thread.ThreadState}.");

            Thread.Sleep(2000); // WaitSleepJoin for 2 seconds

            
            cup_thread.Join(); // this is a blocking thread , it block the execution of the thread where this code is written until the join thread is completed
            cdown_thread.Join(); // this is a blocking thread , it block the execution of the thread where this code is written until the join thread is completed
         

            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("the execution of the thread has been completed => " + thisThread.Name);
            Console.ReadKey();
        }
    }
}
