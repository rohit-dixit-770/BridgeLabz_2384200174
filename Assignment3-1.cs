// Program 1:check if a number is divisible by 5
using System;

class Solution {
    public static void Main() {
        // prompt for user number input
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        // checking whether number is divisible by 5 or not
        bool isDivisible = (number % 5 == 0) ? true : false;
        
        // printing result
        Console.WriteLine("Is the number {0} divisible by 5? {1}" , number , isDivisible);
    }
}





//Program 2: check if the first is the smallest of the 3 numbers.
using System;

class Solution {
    public static void Main() {
        // prompt for user number input
        Console.Write("Enter three numbers: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        
        // checking whether first number is smallest or not
        bool isSmallest = (number1 < number2 && number1 < number3) ? true : false;
        
        // printing result
        Console.WriteLine("Is the first number the smallest? {0}" , isSmallest);
    }
}



// Program 3: check if the first, second, or third number is the largest of the three
using System;

class Solution {
    public static void Main() {
        //prompt user for three numbers input
        Console.Write("Enter three numbers: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());
        
        //checking the largest number
        bool isFirstLargest = number1 > number2 && number1 > number3;
        bool isSecondLargest = number2 > number1 && number2 > number3;
        bool isThirdLargest = !isFirstLargest && !isSecondLargest;

        // Printing the result
        Console.WriteLine("Is the first number the largest? {0}", isFirstLargest);
        Console.WriteLine("Is the second number the largest? {0}", isSecondLargest);
        Console.WriteLine("Is the third number the largest? {0}", isThirdLargest);
    }
}




// Program 4: Finding the largest among three numbers
using System;

class Solution {
    static void Main() {
        Console.Write("Enter three numbers: ");
        int number1 = int.Parse(Console.ReadLine());
        int number2 = int.Parse(Console.ReadLine());
        int number3 = int.Parse(Console.ReadLine());

        bool isFirstLargest = number1 > number2 && number1 > number3;
        bool isSecondLargest = number2 > number1 && number2 > number3;
        bool isThirdLargest = !isFirstLargest && !isSecondLargest;

        Console.WriteLine("Is the first number the largest? {0}", isFirstLargest);
        Console.WriteLine("Is the second number the largest? {0}", isSecondLargest);
        Console.WriteLine("Is the third number the largest? {0}", isThirdLargest);
    }
}

// Program 5: Sum of natural numbers
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0) {
            int sum = (number * (number + 1)) / 2;
            Console.WriteLine("The sum of {0} natural numbers is {1}", number, sum);
        } else {
            Console.WriteLine("The number {0} is not a natural number", number);
        }
    }
}

// Program 6: Voting eligibility
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter age: ");
        int age = int.Parse(Console.ReadLine());

        if (age >= 18) {
            Console.WriteLine($"The person's age is {age} and can vote.");
        } else {
            Console.WriteLine($"The person's age is {age} and cannot vote.");
        }
    }
}

// Program 7: Check if a number is positive, negative, or zero
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0) {
            Console.WriteLine("Positive");
        } else if (number < 0) {
            Console.WriteLine("Negative");
        } else {
            Console.WriteLine("Zero");
        }
    }
}

// Program 8: Spring season check
using System;

class Solution {
    public static void Main(string[] args) {
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);

        if ((month == 3 && day >= 20) || (month == 6 && day <= 20) || (month > 3 && month < 6)) {
            Console.WriteLine("It's a Spring Season.");
        } else {
            Console.WriteLine("Not a Spring Season.");
        }
    }
}

// Program 9: Countdown using while loop
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter the countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        while (counter > 0) {
            Console.WriteLine(counter);
            counter--;
        }
    }
}

// Program 10: Countdown using for loop
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter the countdown start number: ");
        int counter = int.Parse(Console.ReadLine());

        for (int i = counter; i > 0; i--) {
            Console.WriteLine(i);
        }
    }
}

// Program 11: Sum of user-input numbers using do-while loop
using System;

class Solution {
    public static void Main() {
        double total = 0.0;
        double userInput;

        do {
            Console.Write("Enter a number (0 to stop): ");
            userInput = double.Parse(Console.ReadLine());
            total += userInput;
        } while (userInput != 0);

        Console.WriteLine("The total sum is {0}", total);
    }
}

// Program 12: Sum of user-input numbers using while loop
using System;

class Solution {
    public static void Main() {
        double total = 0.0;

        while (true) {
            Console.Write("Enter a number (0 or negative to stop): ");
            double userInput = double.Parse(Console.ReadLine());

            if (userInput <= 0) {
                break;
            }

            total += userInput;
        }

        Console.WriteLine("The total sum is {0}", total);
    }
}

// Program 13: Sum of natural numbers using while loop and formula
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a natural number: ");
        int n = int.Parse(Console.ReadLine());

        int sum = 0, i = 1;
        while (i <= n) {
            sum += i;
            i++;
        }

        int formulaSum = n * (n + 1) / 2;

        Console.WriteLine("Sum using while loop == sum using formula? {0}", sum == formulaSum);
        Console.WriteLine("Sum using while loop: {0}", sum);
        Console.WriteLine("Sum using formula: {0}", formulaSum);
    }
}

// Program 14: Factorial using while loop
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1, i = 1;
        while (i <= number) {
            factorial *= i;
            i++;
        }

        Console.WriteLine("Factorial of {0} is {1}", number, factorial);
    }
}

// Program 15: Factorial using for loop
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a positive integer: ");
        int number = int.Parse(Console.ReadLine());

        int factorial = 1;
        for (int i = 1; i <= number; i++) {
            factorial *= i;
        }

        Console.WriteLine("Factorial of {0} is {1}", number, factorial);
    }
}

// Program 16: Check if a number is natural and print even/odd
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number > 0) {
            Console.WriteLine("{0} is natural.", number);

            for (int i = 1; i <= number; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine("{0} is even.", i);
                } else {
                    Console.WriteLine("{0} is odd.", i);
                }
            }
        } else {
            Console.WriteLine("{0} is not natural.", number);
        }
    }
}

// Program 17: Calculate bonus based on years of service
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter the salary: ");
        double salary = double.Parse(Console.ReadLine());

        Console.Write("Enter years of service: ");
        int yearsOfService = int.Parse(Console.ReadLine());

        if (yearsOfService > 5) {
            double bonus = 0.05 * salary;
            Console.WriteLine($"The bonus amount is {bonus}");
        } else {
            Console.WriteLine("No bonus is applicable.");
        }
    }
}

// Program 18: Multiplication table for a number
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number from 6 to 9: ");
        int number = int.Parse(Console.ReadLine());

        for (int i = 1; i <= 10; i++) {
            Console.WriteLine("{0} * {1} = {2}", number, i, number * i);
        }
    }
}
