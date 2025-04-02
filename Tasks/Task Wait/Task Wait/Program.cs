using System.Diagnostics;
using System.Threading.Tasks;

/* ******************
 * similarly with Thread object using Join() to cause the waiting for the completion of the joining threads, tasks with the wait() method
 * **************** */


namespace TaskFactoryStartNewExample
{
    public class UpCount
    {
        public void Count(int count)
        {
            Console.WriteLine("The task started counting up to {0}.", count);

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("i= {0}, ", i);
            }

            Console.WriteLine("The task completed counting up.");
        }

        public class DownCount
        {
            public void Count(int count)
            {
                Console.WriteLine("The task started counting down from {0}.", count);

                for (int j = count; j >= 1; j--)
                {
                    Console.WriteLine("j= {0}, ", j);
                }

                Console.WriteLine("The task completed counting down.");
            }
        }
        public class Program
        {
            static void Main(string[] args)
            {
                Stopwatch sw = new Stopwatch();

                sw.Start();
                ExecuteWithTasks();
                sw.Stop();

                long timeItTookMilliseconds = sw.ElapsedMilliseconds;
                Console.WriteLine("It took {0} milliseconds to complete the execution of the tasks", timeItTookMilliseconds);

                Console.ReadKey();

            }

            static void ExecuteWithTasks()
            {
                UpCount upCount = new UpCount();
                DownCount downCount = new DownCount();

           

                Action<int> doCount = upCount.Count; // with Action delegate definition through method name
                Task upTask = Task.Factory.StartNew(() =>
                {
                    doCount(50);
                }
                    );

                Task downTask = Task.Factory.StartNew(() =>     //with lambda expression
                {
                    downCount.Count(50);

                });

                upTask.Wait(); // the Thread calling upTask() will block until the completion of upTask
                downTask.Wait();  // the Thread calling upTask() will block until the completion of downTask
            }
        }

    }
}

