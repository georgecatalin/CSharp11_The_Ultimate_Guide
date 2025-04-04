using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefFieldsinRefStructs
{
    internal ref struct RefStruct
    {
        public ref int Value;

        //create a constructor to initialize the ref field
        public RefStruct(ref int initializer)
        {
            Value = ref  initializer;
        }
    }
}
