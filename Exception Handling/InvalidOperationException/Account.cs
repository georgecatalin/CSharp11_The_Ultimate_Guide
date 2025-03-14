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

        private double _currentValue;
        public double CurrentValue 
        {
            get => _currentValue;

            set
            {
                if(value < 0)
                {
                    throw new ArgumentException("This is called in the setter of the property", "CurrentValue"); // this creates an object of the class ArgumentException() which will be caught in the main() method
                }
                else
                {
                    _currentValue = value;
                }
                
            }
        }
    }
}
