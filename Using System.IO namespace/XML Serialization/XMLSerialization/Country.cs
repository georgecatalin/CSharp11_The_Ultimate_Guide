using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerialization
{
    [Serializable]
    public class Country
    {
        public short Id { get; set; }
        public required string Name { get; set; }
    }
}
