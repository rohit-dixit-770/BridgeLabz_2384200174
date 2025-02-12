using System;
using System.Collections.Generic;

// Interface for loan functionality
interface ILoanable
{
    void ApplyForLoan(double amount);
    double CalculateLoanEligibility();
}

// Abstract class for BankAccount
abstract class BankAccount : ILoanable
{
    public string AccountNumber { get; protected set; }
    public string HolderName { get; protected set; }
    protected double Balance; // Encapsulation: balance is protected

    public BankAccount(string accountNumber, string holderName, double initialBalance)
    {
        AccountNumber = accountNumber;
        HolderName = holderName;
        Balance = initialBalance;
    }

    public void Deposit(double amount)
    {
        if (amount > 0)
        {
            Balance += amount;
            Console.WriteLine("Deposited: " + amount + ". New Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Invalid deposit amount.");
        }
    }

    public virtual void Withdraw(double amount)
    {
        if (amount > 0 && amount <= Balance)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount + ". New Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Insufficient balance or invalid amount.");
        }
    }

    public abstract double CalculateInterest();

    public void DisplayAccountDetails()
    {
        Console.WriteLine("Account Number: " + AccountNumber + " , Holder: " + HolderName + " , Balance: " + Balance);
    }

    // Loan interface implementation
    public void ApplyForLoan(double amount)
    {
        Console.WriteLine(HolderName + " has applied for a loan of " + amount);
    }

    public double CalculateLoanEligibility()
    {
        return Balance * 5; // Example: loan eligibility is 5 times the balance
    }
}

// Savings Account class
class SavingsAccount : BankAccount
{
    private double interestRate = 0.04; // 4% annual interest

    public SavingsAccount(string accountNumber, string holderName, double initialBalance)
        : base(accountNumber, holderName, initialBalance) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }
}

// Current Account class
class CurrentAccount : BankAccount
{
    private double interestRate = 0.02; // 2% annual interest

    public CurrentAccount(string accountNumber, string holderName, double initialBalance)
        : base(accountNumber, holderName, initialBalance) { }

    public override double CalculateInterest()
    {
        return Balance * interestRate;
    }

    // Override Withdraw to allow overdraft
    public override void Withdraw(double amount)
    {
        double overdraftLimit = 500;
        if (amount > 0 && amount <= Balance + overdraftLimit)
        {
            Balance -= amount;
            Console.WriteLine("Withdrawn: " + amount + ". New Balance: " + Balance);
        }
        else
        {
            Console.WriteLine("Exceeded overdraft limit or invalid amount.");
        }
    }
}

// Main class
class Program
{
    static void Main()
    {
        List<BankAccount> accounts = new List<BankAccount>
        {
            new SavingsAccount("123456789", "Aman", 1000),
            new CurrentAccount("987654321", "Rahul", 2000)
        };

        foreach (var account in accounts)
        {
            account.DisplayAccountDetails();
            Console.WriteLine("Interest Earned: " + account.CalculateInterest());
            account.Deposit(500);
            account.Withdraw(300);
            Console.WriteLine("Loan Eligibility: " + account.CalculateLoanEligibility());
            Console.WriteLine("-----------------");
        }
    }
}
