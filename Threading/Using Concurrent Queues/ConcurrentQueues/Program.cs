/* Notes:
 * Concurrent collections can be used for simpler scenarios, when there is no need for such granular control, without the need to implement from scratch
 * the locking mechanisms
 * ******************************************************************************************************************************************************** */
using System.Collections.Concurrent;
using System.Threading;


namespace UsingManualResetEventWithSharedResources
{
    public class Shared
    {
        public static ConcurrentQueue<int> Buffer = new ConcurrentQueue<int>(); // the buffer to store the data values
        public const int BufferCapacity = 5; // the maximum capacity of the Buffer
        public static ManualResetEvent ConsumerEvent = new ManualResetEvent(false); // by default it is unsignaled
        public static ManualResetEvent ProducerEvent = new ManualResetEvent(true); // by default it is signaled
        public static void Print()
        {
            Console.WriteLine("Buffer:");

            foreach (int i in Buffer)
            {
                Console.WriteLine($"{i},");
            }

            Console.WriteLine();
        }
    }

    public class Producer
    {
        public void Produce()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} has started ...");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{Thread.CurrentThread.Name} is generating data...");
                Thread.Sleep(2500); //introduce an artificial latency

                if (Shared.Buffer.Count == Shared.BufferCapacity) //verify if the buffer is full
                {
                    Console.WriteLine("The buffer is full.Waiting for the consumer to consume stuffs...");
                    Shared.ProducerEvent.Reset(); // set the ManualResetEvent to unsignaled
                }

                //place the thread in a block mode to wait for the signal from the Consumer Thread
                Shared.ProducerEvent.WaitOne();

                Shared.Buffer.Enqueue(i); // the buffer has at least one place available , hence add a new element
                Console.WriteLine($"{Thread.CurrentThread.Name} produced a new element -> {i} and added it to the buffer");
                Shared.Print();
                //inform the Consumer that a new element has been added
                Shared.ConsumerEvent.Set();

            }

            Console.WriteLine($"{Thread.CurrentThread.Name} was completed ...");
        }
    }

    public class Consumer
    {
        public void Consume()
        {
            Console.WriteLine($"{Thread.CurrentThread.Name} has started ...");

            for (int i = 0; i < 10; i++)
            {


                if (Shared.Buffer.Count == 0)
                {
                    Console.WriteLine("The buffer is empty. Waiting for a signal from the producer...");
                    Shared.ConsumerEvent.Reset(); //set the thread to unsignaled  
                    Shared.ConsumerEvent.WaitOne(); //block the thread to waint for a signal from the producer thread
                }



                Console.WriteLine($"{Thread.CurrentThread.Name} is consuming the data.");
                Thread.Sleep(5000); //introduce an artificial latency of 2.5 seconds

                //consume the data

                //The ConcurrentQueue has a method TryDequeue(out int valuedequeued) and TryPeek(out int valuedequeued)
                bool isSuccessfulDequeue = Shared.Buffer.TryDequeue(out int val);

                if (isSuccessfulDequeue)
                {
                    Console.WriteLine($"{Thread.CurrentThread.Name} consumed \t -> {val}");
                }
                else
                {
                    Console.WriteLine("Error while dequeueing");
                }

                //inform the Producer that at least one value is available
                Shared.ProducerEvent.Set();

                Console.WriteLine($"{Thread.CurrentThread.Name} was completed ...");
            }
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                //create object of the classes
                Producer producer = new Producer();
                Consumer consumer = new Consumer();

                //create thread objects -> note the threads can be created without creating delegates of the ThreadStart() , but by utilizing an overload of the Thread() constructor
                Thread producerThread = new Thread(producer.Produce) { Name = "Producer Thread" };
                Thread consumerThread = new Thread(consumer.Consume) { Name = "Consumer Thread" };

                //start the threads
                producerThread.Start();
                consumerThread.Start();

                //join the threads
                producerThread.Join();
                consumerThread.Join();

                Console.ReadKey();
            }
        }
    }
}
