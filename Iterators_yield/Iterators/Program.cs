using System;
using IteratorsClassLibrary;

namespace Iterators
{
    internal class Program
    {
        static void Main()
        {
            Sample sample = new Sample();

            IEnumerable<int> ienumerable = sample.IteratorMethod();
            IEnumerator<int> ienumerator = ienumerable.GetEnumerator();

            ienumerator.MoveNext();
            Console.WriteLine(ienumerator.Current);

            Console.WriteLine("Do something else at this point....");

            ienumerator.MoveNext();
            Console.WriteLine(ienumerator.Current);

            Console.WriteLine("Do something else at this point.... again");

            ienumerator.MoveNext();
            Console.WriteLine(ienumerator.Current);

            Console.WriteLine("Another possibility to achieve this , in a single step");
            foreach (int i in ienumerable)
            {
                Console.WriteLine(i);
            }

            Console.ReadKey();
        }
    }
}
