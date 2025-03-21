/* the best manner to make use of immutable objects is through readonly structs */


namespace NeedOfImmutability
{
    public readonly struct BankAccount
    {
        private readonly int _accountNumber;
        private readonly double _currentBalance;

        //the readonly(immutable) fields can only be instantiated in constructors(parameterized or not), but not in normal methods

        /// <summary>
        /// By default, structs only permit parameterized constructors, and not parameterless-constructors
        /// </summary>
        /// <param name="accountNumber"></param>
        /// <param name="currentBalance"></param>
        public BankAccount(int accountNumber, double currentBalance)
        {
            _accountNumber = accountNumber;
            _currentBalance = currentBalance;
        }

        //we shall use readonly properties to access the values from outside the class
        public int AccountNumber { get => _accountNumber; init => _accountNumber = value; } // these init-only classes can only be initialized inline, in constructors or in objects initializers
        public double CurrentBalance { 
            get => _currentBalance;
            init
            {
                if(value > 0)
                {
                    _currentBalance = value;
                }
            }
        }
    }

    public class DataStorage
    {
        public static List<BankAccount> GetBankAccounts()
        {
            return new List<BankAccount>
            {
                new BankAccount(){AccountNumber = 100, CurrentBalance=123.5 },
                new BankAccount(){AccountNumber = 125, CurrentBalance= 435.6 }
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
                Console.WriteLine("Hello from \"READONLY STRUCTS \"");

                List<BankAccount> bankAccounts = GetBankAccounts();
                BankAccount firstBankAccount = bankAccounts[0];
                double balance = firstBankAccount.CurrentBalance;

                Console.WriteLine("The balance is {0} ", balance);

            }
        }
    }
}  