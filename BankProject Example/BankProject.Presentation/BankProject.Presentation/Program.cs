using System;
using System.Collections.Generic;


namespace BankProject.Presentation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //display title
            System.Console.WriteLine("************** Harsha Bank *****************");
            System.Console.WriteLine("::Login Page::");

            //declare variables and store username and password
            string username = null;
            string password = null;

            //read username from keyboard
            Console.WriteLine("Username: ");
            username = Console.ReadLine();

            //read password from keyboard only if username was entered
            if (username != null)
            {
                Console.WriteLine("Password: ");
                password = Console.ReadLine();
            }

            //check username and password
            if (username == "system" && password == "manager")
            {
                //declare variable to store menu choice
                int mainMenuChoice = -1;

                do
                {
                    //show main menu
                    System.Console.WriteLine("\n:::Main menu:::");
                    System.Console.WriteLine("1. Customers");
                    System.Console.WriteLine("2. Accounts");
                    System.Console.WriteLine("3. Funds Transfer");
                    System.Console.WriteLine("4. Funds Transfer Statement");
                    System.Console.WriteLine("5. Account Statement");
                    System.Console.WriteLine("0. Exit");

                    //accept menu choice from keyboard
                    System.Console.Write("Enter choice: ");
                    mainMenuChoice = int.Parse(Console.ReadLine());

                    //switch-case to check menu choice
                    switch (mainMenuChoice)
                    {
                        case 1: CustomersMenu(); break;
                        case 2: AccountsMenu(); break;
                        case 3: FundsTransferMenu();break;
                        case 4: DisplayFundsTransferStatement();break;
                        case 5: DisplayAccountStatement(); break;
                    }

                } while (mainMenuChoice != 0);
            }
            else
            {
                Console.WriteLine("Invalid username or password");
            }

            //about to exit
            System.Console.WriteLine("Thank you! Visit again.");
            System.Console.ReadKey();

        }

        static void CustomersMenu()
        {
            //variable to store customers menu choice
            int customerMenuChoice = -1;

            //do-while loop starts
            do
            {
                //print customers menu
                System.Console.WriteLine("\n:::Customers menu:::");
                System.Console.WriteLine("1. Add Customer");
                System.Console.WriteLine("2. Delete Customer");
                System.Console.WriteLine("3. Update Customer");
                System.Console.WriteLine("4. Search Customers");
                System.Console.WriteLine("5. View Customers");
                System.Console.WriteLine("0. Back to Main Menu");

                //accept customers menu choice
                System.Console.Write("Enter choice: ");
                customerMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());

                //switch case
                switch (customerMenuChoice)
                {
                    case 1: CustomerPresentation.AddCustomer(); break;
                    case 5: CustomerPresentation.ViewCustomers(); break;
                }
            } while (customerMenuChoice != 0);
        }


        static void AccountsMenu()
        {
            //variable to store accounts menu choice
            int accountsMenuChoice = -1;

            //do-while loop starts
            do
            {
                //print  accounts menu
                System.Console.WriteLine("\n:::Accounts menu:::");
                System.Console.WriteLine("1. Add Account");
                System.Console.WriteLine("2. Delete Account");
                System.Console.WriteLine("3. Update Account");
                System.Console.WriteLine("4. View Accounts");
                System.Console.WriteLine("0. Back to Main Menu");

                //accept accounts menu choice
                System.Console.Write("Enter choice: ");
                accountsMenuChoice = System.Convert.ToInt32(System.Console.ReadLine());
            } while (accountsMenuChoice != 0);
        }

        static void FundsTransferMenu()
        {
            //do stuff
        }

        static void DisplayFundsTransferStatement()
        {
            //do stuff
        }

        static void DisplayAccountStatement()
        {
            //do stuff
        }
    }
}