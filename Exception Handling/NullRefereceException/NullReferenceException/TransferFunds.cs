using System;
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
                sourceAccount.CurrentValue -= amount;
                destinationAccount.CurrentValue += amount;

                Console.WriteLine($"We transferred from {sourceAccount.AccountHolderName} to {destinationAccount.AccountHolderName} the amount of {amount}");
            }
            catch( NullReferenceException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Invalid destination account");
                throw; // throw the same exception to the calling method to be also visible there
            }
        }
    }
}
