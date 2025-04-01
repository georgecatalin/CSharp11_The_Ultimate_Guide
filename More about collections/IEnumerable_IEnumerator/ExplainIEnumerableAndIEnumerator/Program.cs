using System;
using System.Collections.Generic;

namespace ExplainIEnumerableAndIEnumerator
{
    /// <summary>
    /// This class explains the concepts of IEnumerable and IEnumerator
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create a List object
            List<string> myList = new List<string>() { "George", "Mara", "Sorina"};
            /*  public class  List<T> : IList<T>, IList, IReadOnlyList<T>
             *  public interface IList<T> : ICollection<T>, IEnumerable<T>, IEnumerable
             *   public interface ICollection<T> : IEnumerable<T>, IEnumerable
             *   */

            IEnumerable<string> myList1 = new List<string>();
            myList1 = new Stack<string>();
            myList1 = new Queue<string>();

            
            ICollection<string> myList2 = new List<string>();
            IList<string> myList3 = new List<string>();

            foreach (string s in myList)
            {
                Console.WriteLine(s);
            }

            //IEnumerator is used when reading data from collections with foreach()

            /* public IEnumerable<T>
             * {
             *   IEnumerator<T> GetEnumerator();
             *   } */


            // The following code demonstrates the use of IEnumerator for a foreach loop //
            Console.WriteLine("Displaying with the IEnumerator interface");


            IEnumerator<string> myEnumerator = myList.GetEnumerator();
            myEnumerator.Reset();
            while (myEnumerator.MoveNext())
            {
                Console.WriteLine((string)myEnumerator.Current); //This is actually a string, no need for ToString()
            }
        }
    }
}
