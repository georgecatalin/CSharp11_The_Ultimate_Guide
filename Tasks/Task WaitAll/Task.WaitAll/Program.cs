using System.Diagnostics;
using System.Threading.Tasks;

/* ************************************************************************
 * instead of calling the wait() method for each task object, one can call the static Task.WaitAll() method for wait for all tasks started from that thread to be completed
 * * ********************************************************************** */

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

                /*  public static void WaitAll(params Task[] tasks)
                 can be called either 
                      Task.WaitAll(new Task[] {upTask, downTask}); or simply enumerating the task1 which will be joined in the array
                     params means an enumeration of parameters in a variable number , it is used mostly for arrays passed as arguments
                */

                //Task.WaitAll(new Task[] {upTask, downTask});
                Task.WaitAll(upTask, downTask);
                
            }
        }

    }
}

