/* **************************************************************************************************************************************
Task cancellation is the process of gracefully cancelling the execution of a task.
 * ***********************************************************************************************************************************  */


namespace GenericTasks
{
    public class UpCount
    {
        public int Count(int count, CancellationToken cancellationToken)
        {
            Console.WriteLine("Started the up count towards {0}", count);

            int sum = 0;
            for (int i = 0; i < count; i++)
            {

                if (!cancellationToken.IsCancellationRequested)
                { 
                sum += i;
                Console.Write("i= {0}, ", i);

                Task.Delay(500).Wait();
                }

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

            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource(); //this is the object to be used with the task cancellation



  


            //there might be the case when we will not need the reference variable for the taks, in this case 'upTask' and we can chain ContinueWith() method
            Task.Factory.StartNew(() =>
            {
                return upCount.Count(50,cancellationTokenSource.Token); // pass the token as argument so to be able to access it in the method Count()
            }, cancellationTokenSource.Token).ContinueWith((antecendent) =>
            {

                if (antecendent.Status == TaskStatus.Faulted)
                {
                    //the exception will be thrown here, will have the type AggregateException and certain properties
                    Console.WriteLine(antecendent?.Exception?.InnerExceptions.First().Message);
                }
                else if (antecendent.Status == TaskStatus.RanToCompletion)
                {
                    Console.WriteLine("The result after the execution of the upTask is {0}.", antecendent.Result); // thorough antencent(which is the parameter of the lambda expression one can access the original tasks which terminated
                }

            });

            Task.Delay(5000).Wait();
            cancellationTokenSource.Cancel();

            Task downTask = Task.Factory.StartNew(() => // I used the modern way of a lambda expression
           {
               return downCount.Count(50);
           }).ContinueWith((antecendent) =>
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