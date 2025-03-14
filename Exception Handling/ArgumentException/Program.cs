using System;



namespace NullReferenceExceptionExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            try
            {
                Account georgeAccount = new Account() { AccountId = 100, AccountHolderName = "George", CurrentValue = 10000 };
                Account maraAccount = new Account() { AccountId = 101, AccountHolderName = "Mara", CurrentValue = -5000 }; //  this will throw ArgumentException() cause the setter of CurrentValue is not validated in the constructor
                Account sorinaAccount = null;


                TransferFunds transferFunds = new TransferFunds();
                transferFunds.TransferFund(georgeAccount, maraAccount, 500); 

                transferFunds.TransferFund(maraAccount, sorinaAccount, -1000); //it does not get to this as the exception is caught in the catch()

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
            catch (ArgumentException ex)
            {
                Console.WriteLine("EXCEPTION MESSAGE: " + ex.Message);
                Console.WriteLine("EXCEPTION PARAMETER: " + ex.ParamName);
            }
            
            Console.ReadKey();




        }
    }
}
