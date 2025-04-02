/* **************************************************************************************************************************************
In task, there arise the term "continuation task" which is the task being executed once the original task is completed, either successfully or with an exception.
with the continuation task, one can access the result of the original task or the exception from the original task
The continuation tasks does not block the current running task, unlike any of the Wait(), WaitAll(), WaitAny().
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

                //Unlike Thread.Sleep(), Task.Delay() does not directly block the current thread, instead it creates a new task object , upon with the method Wait() can be applied
                /*
                Task newTaskObjectCreated = Task.Delay(300);
                newTaskObjectCreated.Wait();
                */

                Task.Delay(500).Wait();
                

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

            Func<int, int> func1 = upCount.Count;  // wrote the Func<> delegate using the named method variant
            Task<int> upTask = Task.Factory.StartNew(() =>
            {
                return func1(50);
            });


            Task continuationTaskAfterUpTask = upTask.ContinueWith((antecendent) =>
            {
                Console.WriteLine("The result after the execution of the upTask is {0}.", antecendent.Result); // thorough antencent(which is the parameter of the lambda expression one can access the original tasks which terminated
            });



            Func<int, int> func2 = delegate  // wrote the Func<> delegate using the old fashioned anonymous method with delegate
            {
                return upCount.Count(50);
            };
            Task<int> task2 = Task.Factory.StartNew(() =>
            {
                return func2(50);
            });

            Task continuationTaskAfterTask2 = task2.ContinueWith((antecendent) =>
            {
                Console.WriteLine("The result after the execution of the task2 is {0}.", antecendent.Result);
            });




            Task<ComplexUserType> task3 = Task.Factory.StartNew(() => // I used the modern way of a lambda expression
            {
                return downCount.Count(50);
            });


            Task continuationTaskAfterTask3 = task3.ContinueWith((antecendent) =>
            {
                Console.WriteLine("The result after the execution of the task2 is {0}.", antecendent.Result.Sum);
            });

            Console.ReadKey();
        }
    }
}

// the result returned from the task is obtain through a get only taskobject.Result property

public class ComplexUserType
{
    public int Sum { get; set; }
}