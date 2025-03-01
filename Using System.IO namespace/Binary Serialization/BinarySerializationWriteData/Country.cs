using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySerializationWriteData
{
    [Serializable]
    class Country
    {
        public short countryId { get; set; }
        public required string countryName { get; set; }
        public required string countryRegion { get; set; }
    }
}
