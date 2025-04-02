using System.Diagnostics.Metrics;
using System.Threading.Tasks;

namespace TaskRunConcurrentExecution
{
    public class CountUp
    {
        public void Count(int count)
        {
            Console.WriteLine($"The counting-up starts until {count}");

            for (int i = 0; i < count; i++)
            {
                Console.Write("i ={0}, ", i);
            }

            Console.Write($"The counting-up was completed.");
        }
    }


    public class CountDown
    {
        public void Count(int count)
        {
            Console.WriteLine($"The counting-down starts from {count}");

            for (int j = count; j >= 1; j--)
            {
                Console.Write("j = {0}, ", j);
            }

            Console.WriteLine($"The counting-down was completed.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects
            CountUp countUp = new CountUp();
            CountDown countDown = new CountDown();

            //create the task objects
            //construct the Action delegate object by means anonymous methods which use explicitely the 'delegate' syntax
            Console.WriteLine("\n**********************************************************************************************************");
            Console.WriteLine("construct the Action delegate object by means anonymous methods which use explicitely the 'delegate' syntax");
            Console.WriteLine("\n**********************************************************************************************************");

            Action action1 = delegate
            {
                countUp.Count(50);
            };

            Task task1 = Task.Run(action1);


            Action action2 = delegate
            {
                countDown.Count(50);
            };

            Task task2 = Task.Run(action2);


            //construct the Action delegate object by means of the method name
            Console.WriteLine("\n**********************************************************************************************************");
            Console.WriteLine("construct the Action delegate object by means anonymous methods which use explicitely the method name syntax");
            Console.WriteLine("\n**********************************************************************************************************");
            Action<int> action3 = countUp.Count;

            Task task3 = Task.Run(() => action3(50));

            Action<int> action4 = countDown.Count;

            Task task4 = Task.Run(() => action4(50));

            //construct the delegate parameter of Task.Run() directly as a lambda expression
            Console.WriteLine("\n**********************************************************************************************************");
            Console.WriteLine("//construct the delegate parameter of Task.Run() directly as a lambda expression");
            Console.WriteLine("\n**********************************************************************************************************");
            Task task5 = Task.Run(() =>
            {
                countUp.Count(50);
            });


            Task task6 = Task.Run(() =>
            {
                countDown.Count(50);
            });


            Console.ReadKey();
        }
    }
}

// the order in which the tasks are executed by the Task Scheduler is not guaranteed