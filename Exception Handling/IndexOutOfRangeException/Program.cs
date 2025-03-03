using System;



namespace IndexOutOfRangeExceptionExample
{
    internal class Account
    {
        public string AccountHolderName { get; set; }
        public int AccountCode { get; set; }
        public double CurrentBalance { get; set; }

    }

    internal class Program
    {
        static void Main()
        {
            try
            {
                Account[] accounts = new Account[]
           {
                new Account() {AccountHolderName = "George", AccountCode = 100, CurrentBalance = 120},
                new Account() {AccountHolderName = "Mara", AccountCode = 101, CurrentBalance = 90 },
                new Account() {AccountHolderName = "Sorina", AccountCode = 102, CurrentBalance = 130 },
           };


                for (int i = 0; i < accounts.Length; i++)
                {
                    Console.WriteLine($"{i + 1} -> {accounts[i].AccountHolderName}, {accounts[i].AccountCode}, {accounts[i].CurrentBalance}");
                }

                Console.WriteLine("Enter the serial number:");
                int serial = int.Parse(Console.ReadLine());

                serial--;

                Console.WriteLine($"You chose this -> {accounts[serial].AccountHolderName}, {accounts[serial].AccountCode}, {accounts[serial].AccountCode}");

            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }


            Console.ReadKey();

        }
    }
}
