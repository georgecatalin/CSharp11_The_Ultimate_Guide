/* **************************************************************************************************************************************
 * in case that the lambda expression in the constructor method of the Task object returns a value, then we use
 * public class Task<TResult> : Task generic class inheriting from the regular Task class, and taking all its methods and properties
 * ***********************************************************************************************************************************  */


namespace GenericTasks
{
    public class UpCount
    {
        public int Count(int count)
        {
            Console.WriteLine("Started the up count towards {0}", count);

            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += i;
                Console.Write("i= {0}, ", i);
            }
            Console.WriteLine("Completed the up count");

            return sum;
        }
    }

    public class DownCount
    {
        public ComplexUserType Count(int count)
        {
            Console.WriteLine("Started the down count from {0}", count);

            int sum = 0;
            for (int j = count; j >= 1; j--)
            {
                sum += j;
                Console.Write("j= {0}, ", j);
            }
            Console.WriteLine("Completed the down count");

            return new ComplexUserType() { Sum = sum };
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            UpCount upCount = new UpCount();
            DownCount downCount = new DownCount();

            Func<int,int> func1 = upCount.Count;  // wrote the Func<> delegate using the named method variant
            Task<int> upTask = Task.Factory.StartNew(() =>
            {
                return func1(50);
            });

            Func<int, int> func2 = delegate  // wrote the Func<> delegate using the old fashioned anonymous method with delegate
            {
               return  upCount.Count(50);
            };
            Task<int> task2 = Task.Factory.StartNew(() =>
            {
                return func2(50);
            });

            Task<ComplexUserType> task3 = Task.Factory.StartNew(() => // I used the modern way of a lambda expression
            {
                return downCount.Count(50);
            });

            Task.WaitAll(upTask, task2, task3);

            Console.WriteLine("The values returned are: {0} , \t {1}, \t {2}", upTask.Result, task2.Result, task3.Result.Sum);

            Console.ReadKey();
        }
    }
}

// the result returned from the task is obtain through a get only taskobject.Result property

public class ComplexUserType
{
    public int Sum { get; set; }
}