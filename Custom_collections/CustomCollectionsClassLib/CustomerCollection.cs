using System;
using System.Collections.Generic;
using System.Collections;

namespace CustomCollectionsClassLib
{
    public class CustomerCollection : IEnumerable
    {
        private List<Customer> _list = new List<Customer>();

        public IEnumerator GetEnumerator()
        {
            for(int index =0; index <_list.Count; index++)
            {
                yield return _list[index];
            }
        }
        
        public void Add(Customer customer)
        {
            if (customer.CustomerName.StartsWith("a") || customer.CustomerName.StartsWith("A"))
            {
                _list.Add(customer);
            }
            else
            {
                Console.WriteLine("Unmatched customer naming rule: ERROR");
            }
        }

    }
}
