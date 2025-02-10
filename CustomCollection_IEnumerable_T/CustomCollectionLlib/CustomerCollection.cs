using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionLlib
{
    public class CustomerCollection : IEnumerable<Customer>
    {
        List<Customer> _list = new List<Customer>();

        public IEnumerator<Customer> GetEnumerator()
        {
            for (int index = 0; index < _list.Count; index++)
            {
                yield return _list[index];
            }
        }


       IEnumerator IEnumerable.GetEnumerator()
        {
            for (int index = 0; index < _list.Count; index++)
            {
                yield return _list[index];
            }
        }

       public void Add(Customer item)
        {
            if(item.CustomerType != TypeOfClient.VIPClient)
            {
                _list.Add(item);
            }
            else
            {
                Console.WriteLine("ERROR: Only VIP Clients are added");
            }
        }
    }
}
