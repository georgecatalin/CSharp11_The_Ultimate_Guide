﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullReferenceExceptionExample
{
    internal class TransferFunds
    {
        public void TransferFund(Account sourceAccount, Account destinationAccount, double amount)
        {
            try
            {
                if(amount < 0 || amount > 5000)
                {
                    throw new ArgumentOutOfRangeException("amount", 5000, "This is called from the inner method: argument is out of range");
                }
                sourceAccount.CurrentValue -= amount; //in case of exception this creates an object of that exception
            }
            catch( NullReferenceException ex)
            {
                Console.WriteLine("This is from inner method: " + ex.Message);
                throw new ArgumentNullException( "This is from inner method: There is a null parameter in the source", ex); // throw the same exception to the calling method to be also visible there
            }


            try
            {
                destinationAccount.CurrentValue += amount;
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("This is from inner method: " + ex.Message);
                throw new ArgumentNullException("This is from outer method: There is a null parameter in the destination", ex); // throw the same exception to the calling method to be also visible there
            }
        }
    }
}
