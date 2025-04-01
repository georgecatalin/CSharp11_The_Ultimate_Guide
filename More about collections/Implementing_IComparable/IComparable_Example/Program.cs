using System;
using IComparableLib;


namespace IComparable_Example
{
    internal class Program
    {
        static void Main()
        {
            List<Customer> list = new List<Customer>()
            {
                new Customer() { CustomerID = 4, CustomerName = "Alex" },
                new Customer() { CustomerID = 2,CustomerName = "Cornel"},
                new Customer() { CustomerID = 1, CustomerName = "Mirel"},
                new Customer() { CustomerID = 3, CustomerName= "Daniel" }
            };


            //we shall implement the IComparable interface to the Model Class so that to be able to sort objects of that class

            list.Sort();

            foreach (Customer item in list)
            {
                Console.WriteLine(item.CustomerID + " " + item.CustomerName);
            }
        }
    }
}
