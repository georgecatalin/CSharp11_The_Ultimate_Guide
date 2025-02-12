using System.Net.Http.Headers;
using System;

namespace Covariance
{
    internal class LivingThings
    {
        public int NumberOfLegs { get; set; }
    }

    internal class Bird: LivingThings
    {

    }

    internal class Animal: LivingThings
    {

    }

    internal interface IMover<out T>
    {

        T Move();
    }

    internal class Mover<T> : IMover<T>
    {
        public T thisProp { get; set; }

        public T Move()
        {
            Console.WriteLine("It moves");
            return thisProp;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            LivingThings theObject = new Bird(); // not covariance
            Bird theObject1 = new Bird() { NumberOfLegs =2}; // normal behaviour

            IMover<LivingThings> theObject2 = new Mover<Bird>() { thisProp = theObject1 }; // this is covariance ChildType is in a generic class instead of parent
            Console.WriteLine(theObject2.Move().NumberOfLegs);
        }
    }
}
