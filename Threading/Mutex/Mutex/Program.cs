/* Notes: MUTEX go for Mutual exclusion and it is used when you wish only to allow a single thread to access a shared resource at a time
 * mutex is a lock across threads
 * only one thread can hold a mutex at a time
 * the other threads must wait(block) until the mutex is released
 * *********************************************************************************************************************************** */


namespace MutexExample
{
    public class Program
    {
        private static int counter;
        private static Mutex mutex = new Mutex();

        static void IncrementCounter()  //this will be the method used with the threads
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} has got control and is attempting to lock the mutex object");
            mutex.WaitOne(); //thread attempts to lock 

            try
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} has acquired the lock and is doing its shit...");
                Thread.Sleep(5000);
                counter++;
                Console.WriteLine($"{Thread.CurrentThread.Name} has done its job... Counter is {counter}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                mutex.ReleaseMutex();
                Console.WriteLine($"{Thread.CurrentThread.Name} has released the lock...");
            }
        }

        static void Main(string[] args)
        {
            //create the thread object
            Thread thread1 = new Thread(IncrementCounter) { Name = "First Thread" };
            Thread thread2 = new Thread(IncrementCounter) { Name = "Second Thread" };

            //start the threads
            thread1.Start();
            thread2.Start();

            //join the the threads so the main application waits for these to complete 
            thread1.Join();
            thread2.Join();

            Console.WriteLine($"The final value of the counter is {counter}");
        }
    }
}
