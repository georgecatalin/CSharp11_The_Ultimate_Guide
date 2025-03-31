/* ManualResetEvent verus AutoResetEvent
 * ManualResetEvent -> When signalling using the Set() method, it stays signaled until the Reset() method is called to make it unsignaled. If there are multiple threads to read the same data in parallel, then manualResetEvent is better
 * AutoResetEvent ->  Wheen signalling using the Set() method, it gets automatically unsignaled after releasing one waiting thread. If only one thread wishes to read, then AutoResetEvent is better
 */


namespace ManualResetEventExample
{
    public class Shared
    {
        public static int[] Data { get; set; }
        public static int BatchCount { get; set; }
        public static AutoResetEvent ThisEvent { get; set; }
        public static int BatchSize { get; set; }

        static Shared()
        {

            Data = new int[15];
            BatchCount = 5;
            BatchSize = 3;
            ThisEvent = new AutoResetEvent(false);
        }
    }


    public class Producer
    {
        public void Produce()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} started ....");

            //generate the data
            for (int i = 0; i < Shared.BatchCount; i++)
            {
                for (int j = 0; j < Shared.BatchSize; j++)
                {
                    Shared.Data[i * Shared.BatchSize + j] = i * Shared.BatchSize + j + 1;
                    Thread.Sleep(300); //set an artificial delay         
                }
                //send the signal to the listening thread that the data was generated and to execute its sequence only once
                Shared.ThisEvent.Set(); // ThisEvent is set to True
            }

            Console.WriteLine($"{Thread.CurrentThread.Name} completed.");
        }
    }


    public class Consumer
    {
        public void Consume()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} started ....");

            for (int i = 0; i < Shared.BatchCount; i++)
            {

                Console.WriteLine($"{Thread.CurrentThread.Name} is waiting for a signal from the Producer Thread");
                Shared.ThisEvent.WaitOne();
                Console.WriteLine($"{Thread.CurrentThread.Name} just received the signal that the data is ready...");

                //read the data prepared in the Producer Thread
                for (int j = 0; j < Shared.BatchSize; j++)
                {

                    Console.WriteLine(Shared.Data[i * Shared.BatchSize + j]);
                }
            }

            Console.WriteLine($"{Thread.CurrentThread.Name} completed.");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //create objects of the classes
            Producer producer = new Producer();
            Consumer consumer = new Consumer();

            //create delegates of the ThreadStart
            ThreadStart producerThreadStart = new ThreadStart(producer.Produce);
            ThreadStart consumerThreadStart = new ThreadStart(consumer.Consume);

            //create the thread objects
            Thread producerThread = new Thread(producerThreadStart) { Name = "Producer Thread" };
            Thread consumerThread = new Thread(consumerThreadStart) { Name = "Consumer Thread" };


            //start the threads
            producerThread.Start();
            consumerThread.Start();

            //join the threads so that the main thread waits for their completion before finishing itself
            producerThread.Join();
            consumerThread.Join();


            Console.WriteLine("The main thread completed");
            Console.ReadKey();

        }
    }
}
