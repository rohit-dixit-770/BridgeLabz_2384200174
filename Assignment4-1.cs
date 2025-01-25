// Check Voting Eligibility

using System;

class Solution {
    public static void Main() {
        // Initialize an array and take user input for ages
        int[] ages = new int[10];

        for (int i = 0; i < ages.Length; i++) {
            Console.Write("Age of student {0}: ", i + 1);
            ages[i] = int.Parse(Console.ReadLine());
        }

        // Check voting eligibility based on age
        foreach (int age in ages) {
            if (age < 0) {
                Console.WriteLine("Invalid age");
            } else if (age >= 18) {
                Console.WriteLine("The student with the age {0} can vote", age);
            } else {
                Console.WriteLine("The student with the age {0} cannot vote", age);
            }
        }
    }
}







// Check Number Properties and Compare First & Last Elements

using System;

class Solution {
    public static void Main() {
        // Initialize an array and take user input for numbers
        int[] numbers = new int[5];

        for (int i = 0; i < numbers.Length; i++) {
            Console.Write("Number {0}: ", i + 1);
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Check if the number is positive, negative, or zero and if it's even or odd
        foreach (int num in numbers) {
            if (num > 0) {
                Console.WriteLine("{0} is positive and {1}", num, (num % 2 == 0 ? "even" : "odd"));
            } else if (num < 0) {
                Console.WriteLine("{0} is negative", num);
            } else {
                Console.WriteLine("{0} is zero", num);
            }
        }

        // Compare the first and last elements of the array
        if (numbers[0] == numbers[numbers.Length - 1]) {
            Console.WriteLine("First and last elements are equal.");
        } else if (numbers[0] > numbers[numbers.Length - 1]) {
            Console.WriteLine("First element is greater than the last element.");
        } else {
            Console.WriteLine("First element is less than the last element.");
        }
    }
}

// Multiplication Table of a Number

using System;

class Solution {
    public static void Main() {
        // Prompt the user to enter a number 
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        // Initialize an array 
        int[] table = new int[10];

        for (int i = 1; i <= 10; i++) {
            table[i - 1] = number * i;
        }

        // Display the multiplication table
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine("{0} * {1} = {2}", number, i, table[i - 1]);
        }
    }
}







// Store and Sum Array 

using System;

class Solution {
    public static void Main() {
        // Initialize an array and variables for total and index
        double[] numbers = new double[10];
        double total = 0.0;
        int index = 0;

        // Take input until 0, a negative number, or 10 inputs
        while (true) {
            Console.Write("Number {0}: ", index + 1);
            double input = double.Parse(Console.ReadLine());

            if (input <= 0 || index == 10) {
                break;
            }

            numbers[index++] = input;
        }

        // Calculate the total of the entered numbers
        for (int i = 0; i < index; i++) {
            total += numbers[i];
        }

        // Display entered numbers and their total
        Console.WriteLine("Numbers entered: {0}", string.Join(", ", numbers[..index]));
        Console.WriteLine("Total: {0}", total);
    }
}






// Multiplication Table from 6 to 9

using System;

class Solution {
    public static void Main() {
		// prompt for user to enter number
		Console.WriteLine("Enter a number : ");
        int number = Convert.ToInt(Console.ReadLine());
		
		// Initialize array 
        int[] table = new int[10];
		
        for (int i = 0; i <= 9; i++) {
                table[i] = i * j;
            }
        }

        // Display the multiplication tables
        Console.WriteLine("Multiplication Table for {0}:", number);
        for (int i = 1; i <= 10; i++) {
            Console.WriteLine("{0} * {1} = {2}", number, i, table[i-1]);
            }
        }
    }
}







// Mean Height of Football Team

using System;

class Solution {
    public static void Main() {
        // Initialize an array 
        double[] heights = new double[11];

        // Take input for the heights
        for (int i = 0; i < heights.Length; i++) {
            Console.Write("Height of player {0}: ", i + 1);
            heights[i] = double.Parse(Console.ReadLine());
        }

        // Calculate the mean height
        double total = 0;
        foreach (double height in heights) {
            total += height;
        }
        double mean = total / heights.Length;

        // Display the height
        Console.WriteLine("The mean height of the football team is {0}", mean);
    }
}









// Save Odd and Even Numbers

using System;

class Solution {
    public static void Main() {
        // Prompt the user to enter a natural number
        Console.Write("Enter a natural number: ");
        int number = int.Parse(Console.ReadLine());

        if (number <= 0) {
            Console.WriteLine("Not a natural number.");
        }

        // Initialize arrays to store odd and even numbers
        int[] oddNumbers = new int[number / 2 + 1];
        int[] evenNumbers = new int[number / 2 + 1];
        int oddIndex = 0, evenIndex = 0;

        // Categorize numbers as odd or even
        for (int i = 1; i <= number; i++) {
            if (i % 2 == 0) {
                evenNumbers[evenIndex++] = i;
            } else {
                oddNumbers[oddIndex++] = i;
            }
        }

        // Display the odd and even numbers
        Console.WriteLine("Odd numbers: {0}", string.Join(", ", oddNumbers));
        Console.WriteLine("Even numbers: {0}", string.Join(", ", evenNumbers));
    }
}







// Find Factors of a Number 

using System;

class Solution {
    public static void Main() {
        // Prompt the user to enter a number
        Console.Write("Enter a number : ");
        int number = int.Parse(Console.ReadLine());

        // Initialize an array to store factors and its size
        int maxFactor = 10;
        int[] factors = new int[maxFactor];
        int index = 0;

        // Find factors of the number
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                if (index == maxFactor) {
                    maxFactor *= 2;
                    int[] temp = new int[maxFactor];
                    Array.Copy(factors, temp, factors.Length);
                    factors = temp;
                }
                factors[index++] = i;
            }
        }

        // Display the factors
        Console.WriteLine("Factors of {0}: {1}", number, string.Join(", ", factors));
    }
}

// Copy 2D Array into a 1D Array

using System;

class Solution {
    public static void Main() {
        // Prompt user for dimensions of the 2D array
        Console.Write("Enter the number of rows: ");
        int rows = int.Parse(Console.ReadLine());
		
        Console.Write("Enter the number of columns: ");
        int cols = int.Parse(Console.ReadLine());

        // Initialize the 2D array
        int[,] twoDArray = new int[rows, cols];

        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                Console.Write($"Element at ({i + 1}, {j + 1}): ");
                twoDArray[i, j] = int.Parse(Console.ReadLine());
            }
        }

        // Convert the 2D array into a 1D array
        int[] oneDArray = new int[rows * cols];
        for (int i = 0; i < rows; i++) {
            for (int j = 0; j < cols; j++) {
                oneDArray[i * cols + j] = twoDArray[i, j];
            }
        }

        // Display the 1D array
        Console.WriteLine("Converted 1D Array: {0}", string.Join(", ", oneDArray));
    }
}








// FizzBuzz Program

using System;

class Solution {
    public static void Main() {
        // Prompt user to enter a number
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        // Validate input
        if (number <= 0) {
            Console.WriteLine("Please enter a positive integer.");
        }

        // Initialize an array results
        string[] results = new string[number + 1];

        // Populate the results array 
        for (int i = 0; i <= number; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                results[i] = "FizzBuzz";
            }
            else if (i % 3 == 0) {
                results[i] = "Fizz";
            }
            else if (i % 5 == 0) {
                results[i] = "Buzz";
            }
            else {
                results[i] = i.ToString();
            }
        }

        // Display the results
        for (int i = 0; i <= number; i++) {
            Console.WriteLine("Position {0} = {1}", i, results[i]);
        }
    }
}