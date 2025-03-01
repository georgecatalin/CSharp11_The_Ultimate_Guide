using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JSONSerialization
{
    [Serializable] // Correct the attribute name
    class Customer
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public short Age { get; set; }
    }
}
