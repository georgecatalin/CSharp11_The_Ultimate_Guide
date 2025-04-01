/* *******************************************************************************************************************
 * NOTES: The thread pool is a concept useful when you need to handle multiple small tasks and you wish to avoid to create and destroy the threads individually
 * The Thread Pool is a collection of pre-created and reusable threads created by .NET at runtime.
 * You do not create manually the threads, you just queue the work and the pool manages it.
 * The thread pool is ideal for short lived tasks like I/O, processing jobs and handling requests
 * ***************************************************************************************************************** */


namespace ThreadPoolExample
{
    internal class Program
    {
        static void DoWork(object id)
        {
            int thread_id = (int)id;
            Console.WriteLine($"Thread {thread_id} is executing in {Thread.CurrentThread.ManagedThreadId}");

            Thread.Sleep( 1000 );
            Console.WriteLine($"Thread {thread_id} has completed execution  in {Thread.CurrentThread.ManagedThreadId}");

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Queueing jobs for executing with the Thread Pool...");

            for (int i = 0; i < 10; i++)
            {
                ThreadPool.QueueUserWorkItem(DoWork, i);

            }

            Thread.Sleep( 10000 );
            Console.WriteLine("Main thread completed execution");
        }
    }
}
