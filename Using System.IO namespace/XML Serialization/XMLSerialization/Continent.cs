using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLSerialization
{
    [Serializable]
    public class Continent
    {
        public string Name { get; set; }
        public required List<Country> Countries { get; set; }
    }
}
