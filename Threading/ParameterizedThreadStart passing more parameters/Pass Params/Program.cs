/* When the need arises to pass multiple parameters to a starting thread, this can be achieved through the creation of a class
 * and passing at once all the parameters as properties of that class
 * */

namespace MultipleThreadedApplication
{

    public class MaxCount
    {
        public int maxCounter { get; set; }
    }



    public class Counter
    {
        public void CountUp(object? count)
        {
            try
            {
                Console.WriteLine("Count-up Thread has started");
                Thread.Sleep(1000);

                MaxCount? counter = (MaxCount?)count;

                if(counter == null)
                {
                    return;
                }


                for (int i = 0; i < counter.maxCounter; i++)
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

                MaxCount? counter = (MaxCount?)count;

                if(counter == null)
                  {
                return; 
                  }

                for (int i = counter.maxCounter; i >= 0; i--)
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

            MaxCount count = new MaxCount() { maxCounter = 100 };
            cup_thread.Start(count); // we pass the entire object of the class to the Start() method
            Console.WriteLine($"The status of {cup_thread.Name} is {cup_thread.ThreadState}.");

            // There is a way to pass parameters when creating the thread using ParameterizedThreadStart
            ParameterizedThreadStart threadStart_cdown = new ParameterizedThreadStart(counter.CountDown);
            Thread cdown_thread = new Thread(threadStart_cdown) { Name= "Count-Down Thread" , Priority = ThreadPriority.AboveNormal}; //initialization is done with object initializer instead separately

          
            Console.WriteLine($"The status of {cdown_thread.Name} ({cdown_thread.ManagedThreadId}) is {cdown_thread.ThreadState}.");

            MaxCount counter1 = new MaxCount() { maxCounter = 100 };
            cdown_thread.Start(counter1); // we pass the entire object of the class to the Start() method
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
