using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class BankAccount
    {
        public int accountNumber;
        protected string accountHolder;
        private double balance;

        public BankAccount(int accountNumber, string accountHolder, double balance)
        {
            this.accountNumber = accountNumber;
            this.accountHolder = accountHolder;
            this.balance = balance;
        }

        public double GetBalance()
        {
            return this.balance;
        }
        public void SetBalance(double balance)
        {
            this.balance = balance;
        }
    }

    class SavingsAccount : BankAccount
    {
        public double interestRate;

        public SavingsAccount(int accountNumber, string accountHolder, double balance, double interestRate)
            : base(accountNumber, accountHolder, balance)
        {
            this.interestRate = interestRate;
        }

        public static void Main() 
        {
            SavingsAccount savingsAccount = new SavingsAccount(12348901 , "Rohit" , 50000 , 4.5);
            Console.WriteLine($"Account Number: {savingsAccount.accountNumber}");
            Console.WriteLine($"Account Holder: {savingsAccount.accountHolder}");
            Console.WriteLine($"Account Balance: Rs {savingsAccount.GetBalance()}");
            Console.WriteLine($"Interest Rate: {savingsAccount.interestRate}%");
        }
    }
}
