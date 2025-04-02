using System.Diagnostics; // to be able to use StopWatch class
using System.Threading;
using System.Threading.Tasks;



namespace UseStopWatchClassToComparePerformance
{
    public class UpCount
    {
        public void Count(int count)
        {
            Console.WriteLine("Counting-up started till {0}.", count);

            for (int i = 0; i < count; i++)
            {
                Console.Write("i= {0}, ", i);     
            }

            Console.WriteLine("Counting-up has completed");
        }
    }

    public class DownCount
    {
        public void Count(int count)
        {
            Console.WriteLine("Counting-down started from  {0}.", count);

            for (int j = count; j >= 1; j--)
            {
                Console.Write("i= {0}, ", j);
            }

            Console.WriteLine("Counting-down has completed");
        }

    }


    public class Program
    {

        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();

            stopwatch.Start();
            ExecuteWithTasks();
            stopwatch.Stop();
            long timeForTasks = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("It took {0} milliseconds to complete the operation with tasks.", timeForTasks);

            stopwatch.Restart();
            ExecuteWithThreads();
            stopwatch.Stop();
            long timeForThreads = stopwatch.ElapsedMilliseconds;
            Console.WriteLine("It took {0} milliseconds to complete the operation with threads.", timeForThreads);

            Console.ReadKey();
        }

        static void ExecuteWithTasks()
        {
            UpCount upCount = new UpCount();
            DownCount downCount = new DownCount();

            CountdownEvent countdownEvent = new CountdownEvent(2);

            Task up = Task.Run(() =>
            {
                upCount.Count(50);
                countdownEvent.Signal(); // Signals the task  is over
            });

            Task down = Task.Run(() =>
            {
                downCount.Count(50);
                countdownEvent.Signal(); // Signals the task  is over
            });

            countdownEvent.Wait();  // wait for the signal of completing the two tasks before continuing after this point
        }

        static void ExecuteWithThreads()
        {
            UpCount upCount = new UpCount();
            DownCount downCount = new DownCount();

            CountdownEvent countdownEvent = new CountdownEvent(2); // Implement a CountDownEvent so that the Main thread does not close until tasks complete

            Thread up = new Thread(() =>
            {
                upCount.Count(50);
                countdownEvent.Signal(); // Signals the task  is over
            });

            Thread down = new Thread(() =>
            {
                downCount.Count(50);
                countdownEvent.Signal(); // Signals the task  is over
            });

            up.Start();
            down.Start();

            countdownEvent.Wait();  // wait for the signal of completing the two tasks before continuing after this point
           
        }


    }
}
