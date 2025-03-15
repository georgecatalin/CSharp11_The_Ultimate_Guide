using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaseWhen
{
    internal class InsufficientFundsException : InvalidOperationException
    {

        public InsufficientFundsException() 
        { 
        
        }

        public InsufficientFundsException(string message) : base(message)
        {
            Console.WriteLine("This is called from the child custom exception");
        }

        public InsufficientFundsException(string message, Exception ex) : base(message, ex)
        {

        }

    }
}
