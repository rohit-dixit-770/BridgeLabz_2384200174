using System;
using System.Collections;

namespace BankManagementSystem
{
    class BankAccount
    {
        private static ArrayList allAccounts = new ArrayList();
        private static string bankName;
        private static int totalAccounts = 0;
        private readonly long accountNumber;
        protected string accountHolderName;
        private double balance;
        private static int accountCounter = 1000;
        
        static BankAccount()
        {
            bankName = "INDIAN BANK";
        }

        public static int GenerateAccountNumber()
        {
            Random random = new Random();
            accountCounter++;
            return  accountCounter* 1000 + random.Next(0, 1000); 
        }


        public BankAccount(string accountHolderName, double balance)
        {
            this.accountNumber = GenerateAccountNumber();
            this.accountHolderName = accountHolderName;
            this.balance = balance;
            totalAccounts++;
        }

        public static int GetTotalAccounts()
        {
            return totalAccounts;
        }

        public double GetBalance()
        {
            return this.balance;
        }

        public void Deposit(double amount)
        {
            if (amount > 0)
            {
                this.balance += amount;
                Console.WriteLine($"{amount} deposited successfully");
            }
            else
            {
                Console.WriteLine("Enter valid deposit amount");
            }
        }

        public void Withdraw(double amount)
        {
            if (amount > 0 && this.balance - amount >= 1000)
            {
                this.balance -= amount;
                Console.WriteLine($"{amount} withdrawn successfully");
            }
            else
            {
                Console.WriteLine("Insufficient balance! Minimum balance of 1000 should be maintained");
            }
        }

        public void Display()
        {
            Console.WriteLine("==================================");
            Console.WriteLine($"Bank Name: {bankName}");
            Console.WriteLine($"Account Number: {this.accountNumber}");
            Console.WriteLine($"Account Holder: {this.accountHolderName}");
            Console.WriteLine($"Balance: {this.balance}");
            Console.WriteLine("==================================");
        }

        public static void AddCustomer(BankAccount other)
        {
            allAccounts.Add(other);
        }
        
        public static BankAccount GetAccountByNumber(int accountNumber)
        {
            foreach (BankAccount acc in allAccounts)
            {
                if (acc.accountNumber == accountNumber)
                {
                    return acc; 
                }
            }
            return null;
        }

        public void BankManagement()
        {
            while (true)
            {
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1 - Check Balance");
                Console.WriteLine("2 - Deposit");
                Console.WriteLine("3 - Withdraw");
                Console.WriteLine("4 - Display Account Details");
                Console.WriteLine("5 - Exit");

                int input = Convert.ToInt32(Console.ReadLine());
                                
                switch (input)
                {
                    case 1:
                        Console.WriteLine($"Current Balance: {GetBalance()}");
                        break;
                    case 2:
                        Console.Write("Enter deposit amount: ");
						double depositAmount = Convert.ToDouble(Console.ReadLine());
						
                        if (depositAmount>0)
                        {
                            Deposit(depositAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid amount entered.");
                        }
                        break;
                    case 3:
                        Console.Write("Enter withdrawal amount: ");
						double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        if (withdrawAmount > 0 && this.balance - withdrawAmount > 1000)
                        {
                            Withdraw(withdrawAmount);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Trasaction! Minimum Rs 1000 should be maintained");
                        }
                        break;
                    case 4:
                        Display();
                        break;
                    case 5:
                        Console.WriteLine("Thank you for banking with us!");
                        return;
                    default:
                        Console.WriteLine("Invalid Input. Please try again.");
                        break;
                }
            }
        }

        public static void Main()
        {
            while (true)
            {
                Console.WriteLine("1 - Create New Account");
                Console.WriteLine("2 - Show All Accounts");
                Console.WriteLine("3 - Search Account by Number");
                Console.WriteLine("4 - Exit");
                Console.Write("Choose an option: ");

                int input = Convert.ToInt32(Console.ReadLine());
                
                switch (input)
                {
                    case 1:                        
                        Console.Write("Account Holder Name: ");
                        string accountHolderName = Console.ReadLine();

						double balance;
                        do
						{
							Console.Write("Initial Balance (minimum 1000): ");
							balance = Convert.ToDouble(Console.ReadLine());
						}
                        while (balance <1000);

                        BankAccount newAccount = new BankAccount(accountHolderName, balance);
                        AddCustomer(newAccount);
                        newAccount.BankManagement();
                        break;

                    case 2:
                        Console.WriteLine("All Accounts:");
                        foreach (BankAccount acc in allAccounts)
                        {
                            acc.Display();
                        }
                        break;
                    
                    case 3:
                        Console.Write("Enter Account Number: ");
                        int searchAccountNumber = Convert.ToInt32(Console.ReadLine());
                        BankAccount account = GetAccountByNumber(searchAccountNumber);
                        
                        if (account != null)
                        {
                            account.Display();
                        }
                        else
                        {
                            Console.WriteLine("Account not found.");
                        }
                        break;

                    case 4:
                        Console.WriteLine("Exiting program. Thank you!");
                        return;                 
                }
            }
        }
    }
}
