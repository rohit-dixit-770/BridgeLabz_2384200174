using System;
// Base class BankAccount
public class BankAccount
{
    public string AccountNumber { get; set; }
    public double Balance { get; set; }

    // Constructor 
    public BankAccount(string accountNumber, double balance)
    {
        this.AccountNumber = accountNumber;
        this.Balance = balance;
    }

    // Virtual method to display account type
    public virtual void DisplayAccountType()
    {
        Console.WriteLine("Bank Account");
    }

    // Method to display account details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Account Number: "+AccountNumber+", Balance: "+Balance);
    }
}

// Subclass SavingsAccount
public class SavingsAccount : BankAccount
{
    public double InterestRate { get; set; }

    // Constructor 
    public SavingsAccount(string accountNumber, double balance, double interestRate)
        : base(accountNumber, balance)
    {
        this.InterestRate = interestRate;
    }

    // Overriding the DisplayAccountType method
    public override void DisplayAccountType()
    {
        Console.WriteLine("Savings Account");
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Interest Rate: "+InterestRate+"%");
    }
}

// Subclass CheckingAccount
public class CheckingAccount : BankAccount
{
    public double WithdrawalLimit { get; set; }

    // Constructor
    public CheckingAccount(string accountNumber, double balance, double withdrawalLimit)
        : base(accountNumber, balance)
    {
        this.WithdrawalLimit = withdrawalLimit;
    }

    // Overriding the DisplayAccountType method
    public override void DisplayAccountType()
    {
        Console.WriteLine("Checking Account");
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Withdrawal Limit: "+WithdrawalLimit);
    }
}

// Subclass FixedDepositAccount
public class FixedDepositAccount : BankAccount
{
    public int TermLength { get; set; }

    // Constructor
    public FixedDepositAccount(string accountNumber, double balance, int termLength)
        : base(accountNumber, balance)
    {
        this.TermLength = termLength;
    }

    // Overriding the DisplayAccountType method
    public override void DisplayAccountType()
    {
        Console.WriteLine("Fixed Deposit Account");
    }

    // Overriding the DisplayDetails method 
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Term Length: "+TermLength+" months");
    }
}

// Main program 
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different account types
        BankAccount savingsAccount = new SavingsAccount("SA12345", 50000.00, 3.5);
        BankAccount checkingAccount = new CheckingAccount("CA12345", 30000.00, 1000.00);
        BankAccount fixedDepositAccount = new FixedDepositAccount("FD12345", 100000.00, 10);

        // Storing the objects in an array of BankAccount type
        BankAccount[] accounts = { savingsAccount, checkingAccount, fixedDepositAccount };

        // Displaying account type and details
        foreach (BankAccount account in accounts)
        {
            account.DisplayAccountType();
            account.DisplayDetails();
            Console.WriteLine();
        }
    }
}
