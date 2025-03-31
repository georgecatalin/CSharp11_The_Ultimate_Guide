/* in the current scenario: we have two classes, a producer class and a consumer class.
 * The producer class corresponds to a thread, and the consumer class corresonds to other thread. The consumer thread waits for the producer class to generate data before acting on it
 * In this complex scenario we produce data in the Producer in batches, and we consume it in the Consumer also in Batches
 
 */


namespace ManualResetEventExample
{
    public class Shared
    {
        public static int[] Data { get; set; }
        public static int BatchCount { get; set; }
        public static ManualResetEvent ThisEvent { get; set; }
        public static int BatchSize { get; set; }

        static Shared()
        {

            Data = new int[15];
            BatchCount = 5;
            BatchSize = 3;
            ThisEvent = new ManualResetEvent(false);
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
                Console.WriteLine("The ManualResetEvent is set to False again...");
                Shared.ThisEvent.Reset();

                Console.WriteLine($"{Thread.CurrentThread.Name} sent a RESET signal...");
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
