using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    internal class Subscriber
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("The sum is " + a + b);
        }
    }
}
