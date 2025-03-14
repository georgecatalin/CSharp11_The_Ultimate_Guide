using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceExceptionExample
{
    internal class Account
    {
        public int AccountId { get; set; }  
        public required string  AccountHolderName { get; set; }
        public double CurrentValue { get; set; }
    }
}
