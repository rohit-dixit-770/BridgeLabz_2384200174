//1. Handling File Not Found Exception
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "data.txt";

        try
        {
            if (File.Exists(filePath))
            {
                string fileContent = File.ReadAllText(filePath);
                Console.WriteLine("File Contents:\n" + fileContent);
            }
            else
            {
                throw new FileNotFoundException();
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("File not found.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("An I/O error occurred: " + ex.Message);
            Console.ReadLine();
        }
    }
}


//2. Handling Division and Input Errors
using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Enter the first number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter the second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            double result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Invalid input. Please enter numeric values.");
            
        }
        Console.ReadLine();

    }
}


//3. Creating and Handling a Custom Exception
using System;

namespace CustomExceptionExample
{
    // Create a custom exception called InvalidAgeException
    public class InvalidAgeException : Exception
    {
        public InvalidAgeException(string message) : base(message)
        {
        }
    }

    class Program
    {
        // Write a method ValidateAge(int age) that throws InvalidAgeException if age is below 18
        static void ValidateAge(int age)
        {
            if (age < 18)
            {
                throw new InvalidAgeException("Age must be 18 or above.");
            }
        }

        static void Main()
        {
            try
            {
                // Take user input
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());

                // Call ValidateAge()
                ValidateAge(age);

                // If no exception, print "Access granted!"
                Console.WriteLine("Access granted!");
            }
            catch (InvalidAgeException ex)
            {
                // If an exception occurs, display "Age must be 18 or above"
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                // Handle case where user enters a non-numeric value
                Console.WriteLine("Error: Please enter a valid numeric age.");
            }
        }
    }
}



//4. Handling Multiple Exceptions
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Accept an integer array from the user
            Console.Write("Enter the number of elements in the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Accept an index number from the user
            Console.Write("Enter the index to retrieve the value from: ");
            int index = int.Parse(Console.ReadLine());

            // Retrieve and print the value at the given index
            int value = array[index];
            Console.WriteLine($"Value at index {index}: {value}");
        }
        catch (IndexOutOfRangeException)
        {
            // Handle index out of range
            Console.WriteLine("Invalid index!");
        }
        catch (NullReferenceException)
        {
            // Handle array is null
            Console.WriteLine("Array is not initialized!");
        }
        catch (FormatException)
        {
            // Handle invalid input format
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}


//5. Using using Statement for File Handling
using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filePath = "info.txt";

        try
        {
            // Using statement ensures StreamReader is properly closed
            using (StreamReader reader = new StreamReader(filePath))
            {
                string firstLine = reader.ReadLine();
                Console.WriteLine("First Line: " + firstLine);
            }
        }
        catch (IOException)
        {
            // Handle any IOException that may occur
            Console.WriteLine("Error reading file.");
        }
    }
}


//6. Handling Invalid Input in Interest Calculation
using System;

namespace InterestCalculation
{
    class Program
    {
        // Method to calculate interest
        static double CalculateInterest(double amount, double rate, int years)
        {
            if (amount < 0 || rate < 0)
            {
                throw new ArgumentException("Amount and rate must be positive.");
            }

            double interest = amount * rate * years / 100;
            return interest;
        }

        static void Main()
        {
            try
            {
                // Taking user input
                Console.Write("Enter the principal amount: ");
                double amount = double.Parse(Console.ReadLine());

                Console.Write("Enter the interest rate (as a percentage): ");
                double rate = double.Parse(Console.ReadLine());

                Console.Write("Enter the number of years: ");
                int years = int.Parse(Console.ReadLine());

                // Calling CalculateInterest method
                double interest = CalculateInterest(amount, rate, years);
                Console.WriteLine("Calculated Interest: " + interest);
            }
            catch (ArgumentException ex)
            {
                // Handling ArgumentException
                Console.WriteLine("Invalid input: " + ex.Message);
            }
            catch (FormatException)
            {
                // Handling FormatException for invalid numeric input
                Console.WriteLine("Error: Please enter valid numeric values.");
            }
        }
    }
}


//7. Demonstrating finally Block Execution
using System;
class Program
{
    static void Main()
    {
        try
        {
            // Take two integers from the user
            Console.Write("Enter the first integer: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter the second integer: ");
            int num2 = int.Parse(Console.ReadLine());

            // Perform division
            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            // Handle DivideByZeroException
            Console.WriteLine("Error: Cannot divide by zero.");
        }
        catch (FormatException)
        {
            // Handle FormatException for invalid input
            Console.WriteLine("Error: Please enter valid integers.");
        }
        finally
        {
            // Ensure this message is always printed
            Console.WriteLine("Operation completed.");
        }
    }
}


//8.  Propagating Exceptions Across Methods
using System;

class Program
{
    // Method1(): Throws an ArithmeticException (10 / 0)
    static void Method1()
    {
        throw new ArithmeticException("ArithmeticException: Division by zero.");
    }

    // Method2(): Calls Method1()
    static void Method2()
    {
        Method1();
    }

    // Main(): Calls Method2() and handles the exception
    static void Main()
    {
        try
        {
            Method2();
        }
        catch (ArithmeticException ex)
        {
            // Handle the exception in Main() and print the message
            Console.WriteLine("Handled exception in Main: " + ex.Message);
        }
    }
}


//9. Using Nested try-catch Blocks
using System;

class Program
{
    static void Main()
    {
        try
        {
            // Take an array from the user
            Console.Write("Enter the number of elements in the array: ");
            int arraySize = int.Parse(Console.ReadLine());
            int[] array = new int[arraySize];

            for (int i = 0; i < arraySize; i++)
            {
                Console.Write($"Enter element {i + 1}: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            // Take the index and divisor from the user
            Console.Write("Enter the index to retrieve the value from: ");
            int index = int.Parse(Console.ReadLine());

            Console.Write("Enter the divisor: ");
            int divisor = int.Parse(Console.ReadLine());

            try
            {
                // Try to access the element at the given index
                int value = array[index];

                try
                {
                    // Try to divide the element by the divisor
                    int result = value / divisor;
                    Console.WriteLine($"Result of dividing element at index {index} by {divisor}: {result}");
                }
                catch (DivideByZeroException)
                {
                    // Handle division by zero
                    Console.WriteLine("Cannot divide by zero!");
                }
            }
            catch (IndexOutOfRangeException)
            {
                // Handle invalid array index
                Console.WriteLine("Invalid array index!");
            }
        }
        catch (FormatException)
        {
            // Handle invalid input format
            Console.WriteLine("Error: Please enter valid numeric values.");
        }
    }
}


//10.  Implementing a Bank Transaction System
using System;

namespace BankTransactionSystem
{
    // Custom exception for insufficient funds
    public class InsufficientFundsException : Exception
    {
        public InsufficientFundsException(string message) : base(message)
        {
        }
    }

    public class BankAccount
    {
        public double Balance { get; private set; }

        public BankAccount(double initialBalance)
        {
            Balance = initialBalance;
        }

        // Withdraw method
        public void Withdraw(double amount)
        {
            if (amount < 0)
            {
                throw new ArgumentException("Invalid amount!");
            }

            if (amount > Balance)
            {
                throw new InsufficientFundsException("Insufficient balance!");
            }

            Balance -= amount;
            Console.WriteLine($"Withdrawal successful, new balance: {Balance}");
        }
    }

    class Program
    {
        static void Main()
        {
            try
            {
                // Initialize bank account with an initial balance
                Console.Write("Enter the initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());

                BankAccount account = new BankAccount(initialBalance);

                // Take withdrawal amount from user
                Console.Write("Enter the amount to withdraw: ");
                double amount = double.Parse(Console.ReadLine());

                // Call Withdraw method
                account.Withdraw(amount);
            }
            catch (InsufficientFundsException ex)
            {
                // Handle InsufficientFundsException
                Console.WriteLine(ex.Message);
            }
            catch (ArgumentException ex)
            {
                // Handle ArgumentException
                Console.WriteLine(ex.Message);
            }
            catch (FormatException)
            {
                // Handle FormatException for invalid input
                Console.WriteLine("Error: Please enter a valid numeric value.");
            }
        }
    }
}

