using System;
using CustomCollectionsClassLib;


namespace CustomCollections
{
    internal class Program
    {
        static void Main()
        {
            CustomerCollection customerCollection = new CustomerCollection()
            {
                new Customer { CustomerID = 1, CustomerName ="AGeorge", CustomerEmail="email1@something.com", CustomerType= TypeOfCustomer.VIPCustomer},
                new Customer { CustomerID = 2, CustomerName ="AMara", CustomerEmail="email2@something.com", CustomerType= TypeOfCustomer.RegularCustomer},
                new Customer { CustomerID = 3, CustomerName = "ASorina", CustomerEmail = "email3@something.com", CustomerType = TypeOfCustomer.VIPCustomer}
            };


            customerCollection.Add(new Customer { CustomerID = 4, CustomerName = "Sorin", CustomerEmail = "email4@email.com", CustomerType = TypeOfCustomer.RegularCustomer });

            foreach (Customer customer in customerCollection)
            {
                Console.WriteLine(customer.CustomerName + " " + customer.CustomerEmail);
            }

            Console.ReadKey();
        }
    }
}
