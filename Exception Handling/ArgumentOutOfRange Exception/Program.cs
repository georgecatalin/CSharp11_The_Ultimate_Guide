using System;



namespace NullReferenceExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Account georgeAccount = new Account() { AccountId = 100, AccountHolderName = "George", CurrentValue = 10000 };
            Account maraAccount = new Account() { AccountId = 101, AccountHolderName = "Mara", CurrentValue = 50000 };
            Account sorinaAccount = null;

            try
            {
                TransferFunds transferFunds = new TransferFunds();
                transferFunds.TransferFund(maraAccount, maraAccount, 5500); // This will throw an ArgumentOutOfRange() exception

                transferFunds.TransferFund(maraAccount, sorinaAccount, 1000); // this will throw NullReferenceException because sorinaAccount is null

                Console.WriteLine("Money transferred successfully.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Same here: this is run in the outer method with InnerException -> "+ ex.InnerException.Message);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
            }
            
            Console.ReadKey();




        }
    }
}
