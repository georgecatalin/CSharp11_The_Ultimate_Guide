/* **********************************************************************************************************************************
 * NOTES:
 * The semaphore is a synchronisation primitive that limits and controls the access to a block of code (a shared resource)
 * Semaphore has two parameters => semaphore(initial_count, max_count). Whenever the maximum count is reached, control is blocked untol the resource is released 
 * ********************************************************************************************************************************** */

// scenario: Let’s imagine we have 5 workers, but only 2 tools available, so only 2 workers can work at a time.


using System;
using System.Threading;


namespace SemaphoreExample
{
    internal class Program
    {
        public static Semaphore semaphore = new Semaphore(2, 2);

        public static void WorkerThread(object? id)
        {
            Console.WriteLine($"The worker {id} has started and it  is waiting to acquire the shared resource...");

            //attempt to acquire the shared resource if it is available
            semaphore.WaitOne();

            Console.WriteLine($"The worker {id} has acquired the resource and it is doing its job now.");
            Thread.Sleep(3000); //simulate latency

            semaphore.Release();//release the lock on the shared resource
            Console.WriteLine($"The worker {id} released the resource for use with other threads");


        }

        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Thread thread = new Thread(WorkerThread);
                thread.Start(i); //passing the argument to the thread
            }
              

            Console.ReadKey();
        }
    }
}
