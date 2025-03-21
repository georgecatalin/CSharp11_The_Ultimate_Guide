namespace NeedOfImmutability
{
    public class BankAccount
    {
        public int AccountNumber { get; set; }
        public double CurrentBalance { get; set; }
    }

    public class DataStorage
    {
        public static List<BankAccount> GetBankAccounts()
        {
            return new List<BankAccount>
            {
                new BankAccount() {AccountNumber = 1, CurrentBalance = 1550.5},
                new BankAccount() {AccountNumber =2 , CurrentBalance = 3145.3}
            };
        }

        public static double GetCurrentBalance(BankAccount bankAccount)
        {
            bankAccount.CurrentBalance = 234.5; // by mistake the property can be modified outside the class -> here comes the need for immutability
            return bankAccount.CurrentBalance;
        }

        internal class Program
        {
            static void Main(string[] args)
            {
                List<BankAccount> bankAccounts = GetBankAccounts();
                BankAccount firstBankAccount = bankAccounts[0];
                double balance = firstBankAccount.CurrentBalance;

                Console.WriteLine("The balance is {0} ", balance);

            }
        }
    }
}