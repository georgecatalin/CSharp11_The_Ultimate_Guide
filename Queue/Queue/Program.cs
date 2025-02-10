using System;
using System.Collections.Generic;

namespace QueueExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create a Queue object FIFO
            Queue<string> myQueue = new Queue<string>();

            //add elements to the queue
            myQueue.Enqueue("Task 1");
            myQueue.Enqueue("Taks 2");
            myQueue.Enqueue("Task 3");
            myQueue.Enqueue("Task 4");
            myQueue.Enqueue("Task 5");

            //print elements of the queue FIFO
            foreach (var item in myQueue)
            {
                Console.WriteLine(item);
            }


            Console.Write("\nTotal number of elements in the Queue " + myQueue.Count);
            //retrieve element from the queue
            string element = myQueue.Dequeue();
            Console.WriteLine("\nRetrieved element from the queue that was deleted " + element);


            Console.Write("\nTotal number of elements in the Queue " + myQueue.Count);

            //display element from the queue
            string element1=myQueue.Peek();
            Console.WriteLine("\nPeek() - >" + element1);

            Console.Write("\nTotal number of elements in the Queue " + myQueue.Count);

            Console.ReadKey();
        }
    }
}
