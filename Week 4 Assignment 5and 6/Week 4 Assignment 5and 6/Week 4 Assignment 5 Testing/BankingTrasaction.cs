using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_5and6_Testing
{
    public class BankAccount
    {
        private double balance;

        public BankAccount(double initialBalance = 0)
        {
            balance = initialBalance;
        }

        public void Deposit(double amount)
        {
            if (amount <= 0) throw new ArgumentException("Deposit amount must be positive.");
            balance += amount;
        }

        public bool Withdraw(double amount)
        {
            if (amount > balance) return false;
            if (amount <= 0) throw new ArgumentException("Withdrawal amount must be positive.");
            balance -= amount;
            return true;
        }

        public double GetBalance()
        {
            return balance;
        }
    }
}
