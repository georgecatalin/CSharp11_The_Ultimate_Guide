using System.Diagnostics;
using System.Threading.Tasks;


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

                CountdownEvent countdown = new CountdownEvent(2);

                Action<int> doCount = upCount.Count; // with Action delegate definition through method name
                Task upTask = Task.Factory.StartNew(() =>
                {
                    doCount(50);
                    countdown.Signal();
                }
                    );

                Task downTask = Task.Factory.StartNew(() =>     //with lambda expression
                {
                    downCount.Count(50);
                    countdown.Signal();
                });

                countdown.Wait(); // do not execute code after this point before getting the signalling that the countDownEvent is O
            }
        }

    }
}

//* Task object can be created either by using Task.Run() or Task.Factory.StartNew(). The advantage of Task.Factory.StartNew() is that it allows multiple parameters
//to control upon the creation of the object. There is no guarantee that between multiple executions , it will take the same amount of time for the same block of code