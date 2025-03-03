using System;

namespace FormatExceptionExample
{
    internal class BankAccount
    {
        public string AccountHolderName { get; set; }
        public int AccountCode { get; set; }

        public double AccountValue { get; set; }
    }

    internal class Program
    {
        static void Main(string[] args)
        {

            try
            {
                BankAccount bankAccount = new BankAccount();

                Console.WriteLine("Enter the name of the account holder");
                bankAccount.AccountHolderName = Console.ReadLine();

                Console.WriteLine("Enter account code");
                bankAccount.AccountCode = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the account value");
                bankAccount.AccountValue = double.Parse(Console.ReadLine());

                Console.WriteLine("Account was completely registered");

                Console.WriteLine(bankAccount.AccountHolderName + " " + bankAccount.AccountCode + " " + bankAccount.AccountValue);
            }
            catch(FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
           
            Console.ReadKey();
        }
    }
}
