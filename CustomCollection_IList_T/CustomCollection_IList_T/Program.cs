using System;
using System.Collections.Generic;
using System.Collections;
using CustomCollectionLib;



namespace CustomCollection_IList_T
{
    internal class Program
    {
        static void Main()
        {
            CustomerCollection customers = new CustomerCollection()
            {
                new Customer() { CustomerName = "AGeorge", CustomerID = 100, CustomerType = TypeOfCustomer.VIPCustomer},
                new Customer() { CustomerName = "AMara", CustomerID = 101, CustomerType = TypeOfCustomer.VIPCustomer},
                new Customer() { CustomerName = "ASorina", CustomerID = 102, CustomerType = TypeOfCustomer.RegularCustomer},
            };

            Customer newCustomer = new Customer() { CustomerName = "Sorin", CustomerID = 200, CustomerType = TypeOfCustomer.VIPCustomer };
            Customer newCustomer1 = new Customer() { CustomerName = "ASorin", CustomerID = 200, CustomerType = TypeOfCustomer.VIPCustomer };

            customers.Add(newCustomer);
            customers.Add(newCustomer1);

            Console.WriteLine("The number of customers in the collection is " + customers.Count);

            bool isCustomerIn = customers.Contains(newCustomer1);
            Console.WriteLine("Is the customer in the collection  => " + isCustomerIn);

            customers.Remove(newCustomer1);
            Console.WriteLine("After Remove() The number of customers in the collection is " + customers.Count);

            Customer thisCustomer = customers.Find(customer => customer.CustomerName.StartsWith("AG"));
            Console.WriteLine(thisCustomer.CustomerID + " " + thisCustomer.CustomerName);

            List<Customer> newCustomerList = customers.FindAll(customer => customer.CustomerName.StartsWith("AS"));
            Console.WriteLine("list of found items ");

            foreach (var item in newCustomerList) Console.WriteLine(item.CustomerName + " " + item.CustomerID);

            Console.ReadKey();

            //indexer
            Console.WriteLine("the element is position 1 is "  + customers[0].CustomerName + customers[0].CustomerID);

            //IndexOf()
            int findMe = 0;
            if(customers.IndexOf(newCustomer1)!=null)
            {
                Console.WriteLine(findMe);
            }

            //Remove()
            customers.RemoveAt(1);


        }
    }
}
