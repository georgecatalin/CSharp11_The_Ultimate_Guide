using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollectionLib
{
    public  class CustomerCollection :IList<Customer>
    {

        private List<Customer> _list = new List<Customer>();

        public int Count => _list.Count;

        public bool IsReadOnly => true;

        public Customer this[int index]
        { get => _list[index]; 
          set => _list[index] = value; }

        public void Add(Customer item)
        {
            if (item.CustomerName.StartsWith("A") || item.CustomerName.StartsWith("a"))
            {
                _list.Add(item);
            }
            else
            {
                Console.WriteLine("Customer name is not valid");
            }
        }

        public void Clear()
        {
            _list.Clear();
        }

        public bool Contains(Customer item)
        {
            return _list.Contains(item);
        }

        public void CopyTo(Customer[] array, int arrayIndex)
        {
            _list.CopyTo(array, arrayIndex);
        }

        public IEnumerator<Customer> GetEnumerator()
        {
            for (int index = 0; index < Count; index++)
            {
                yield return _list[index];
            }
        }

        public bool Remove(Customer item)
        {
            return _list.Remove(item);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }


        public Customer Find(Predicate<Customer> predicate)
        {
            return _list.Find(predicate);
        }

        public List<Customer> FindAll(Predicate<Customer> predicate)
        {
            return _list.FindAll(predicate);
        }

        public int IndexOf(Customer item)
        {
            return _list.IndexOf(item);
        }

        public void Insert(int index, Customer item)
        {
            if(index < 0 || index >= Count)
            {
                Console.WriteLine("You entered an incorrect index");
            }
            else
            {
                _list.Insert(index, item);
            }
                
        }

        public void RemoveAt(int index)
        {
            if (index < 0 || index >= Count)
            {
                Console.WriteLine("You entered an incorrect index");
            }
            else
            {
                _list.RemoveAt(index);
            }
        }
    }
}
