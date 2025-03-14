using System;



namespace ExceptionLogger
{
    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Account georgeAccount = new Account() { AccountId = 100, AccountHolderName = "George", CurrentValue = 1000 };
                Account maraAccount = new Account() { AccountId = 101, AccountHolderName = "Mara", CurrentValue = 5000 }; //  this will throw ArgumentException() cause the setter of CurrentValue is not validated in the constructor
                Account sorinaAccount = null;


                TransferFunds transferFunds = new TransferFunds();
                transferFunds.TransferFund(georgeAccount, maraAccount, 2000); //this triggers  an InvalidOperationException() as per the TransferFunds() method

                transferFunds.TransferFund(maraAccount, sorinaAccount, 1000); //

                Console.WriteLine("Money transferred successfully.");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Same here: this is run in the outer method with InnerException -> " + ex.InnerException.Message);
                ExceptionLogger.AddException(ex);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.ActualValue);
                Console.WriteLine(ex.ParamName);
                ExceptionLogger.AddException(ex);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine("EXCEPTION MESSAGE: " + ex.Message);
                Console.WriteLine("EXCEPTION PARAMETER: " + ex.ParamName);
                ExceptionLogger.AddException(ex);
            }
            catch (InsufficientFundsException ex)
            {
                Console.WriteLine(ex.Message); // at all times catch the child Exception() before catching the parent Exception()
                Console.WriteLine(ex.StackTrace);
                ExceptionLogger.AddException(ex);
            }
            catch (InvalidOperationException ex) // this catches the object of InvalidOperationException which was raised in the TransferFund() method
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                ExceptionLogger.AddException(ex);
            }

            Console.ReadKey();




        }
    }
}
