namespace NeedOfImmutability
{
    public class BankAccount
    {
        private readonly int _accountNumber;
        private readonly double _currentBalance;

        //the readonly(immutable) fields can only be instantiated in constructors(parameterized or not), but not in normal methods
        public BankAccount(int accountNumber, double currentBalance)
        {
            _accountNumber = accountNumber;
            _currentBalance = currentBalance;
        }

        //we shall use readonly properties to access the values from outside the class
        public int AccountNumber { get => _accountNumber; }
        public double CurrentBalance { get => _currentBalance; }
    }

    public class DataStorage
    {
        public static List<BankAccount> GetBankAccounts()
        {
            return new List<BankAccount>
            {
                new BankAccount(1,1550.56),
                new BankAccount(2,3455.67) 
            };
        }

        public static double GetCurrentBalance(BankAccount bankAccount)
        {
            //bankAccount.CurrentBalance = 234.5; // by mistake the property can be modified outside the class -> here comes the need for immutability
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