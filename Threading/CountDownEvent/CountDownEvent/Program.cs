/* ***************************************************************************************************************************
 * Notes:
 * the countdownevent acts like a counter-based gate
 * the counter is initialized, and each thread signals to the counter it has completed its activitu
 * the thread which waits for the counter, knows this way all the threads were completed
 * ************************************************************************************************************************** */

namespace CountDownEvent
{
    internal class Program
    {
        public static CountdownEvent countdownEvent = new CountdownEvent(5); // 5 is the initial count that is the execution of 5 threads can be monitored

        static void DoStuff(object? id)
        {
            int threadId = (int) (id??0);
            Console.WriteLine("{0} has started its execution as {1}.", threadId, Thread.CurrentThread.ManagedThreadId);

            //simulate latency so that the thread does its music
            Thread.Sleep(new Random().Next(2000, 4000));

            Console.WriteLine("{0} has completed its execution as {1}. \t -> signaled to the CountDownEvent", threadId, Thread.CurrentThread.ManagedThreadId);

            countdownEvent.Signal();// I am done
        }


        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(DoStuff);
                thread.Start(i);
            }

            Console.WriteLine("Main Thread which is identified as {0} is waiting for all other threads to complete their work", Thread.CurrentThread.ManagedThreadId);
            countdownEvent.Wait();

            Console.WriteLine("The work of all threads is done, countdownevent variable is O. ");

            Console.ReadKey();
        }
    }
}
