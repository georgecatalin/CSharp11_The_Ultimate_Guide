using System;
using System.Collections.Generic;

namespace IteratorsClassLibrary
{
    public class Sample
    {
        public IEnumerable<int> IteratorMethod()
        {
            Console.WriteLine("Started the execution of the iterator method");
            yield return 2011;
            Console.WriteLine("Continue the execution of the iterator method");
            yield return 1978;
            Console.WriteLine("Execute once more the iterator method");
            yield return 1953;
        }
    }
}
