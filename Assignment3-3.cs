// Program 1: Armstrong Number Check
using System;

class Solution {
    static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int originalNumber = number;
        int sum = 0;

        while (originalNumber != 0) {
            int remainder = originalNumber % 10;
            sum += (int)Math.Pow(remainder, 3);
            originalNumber /= 10;
        }

        if (sum == number) {
            Console.WriteLine("{0} is an Armstrong number.", number);
        } else {
            Console.WriteLine("{0} is not an Armstrong number.", number);
        }
    }
}

// Program 2: Count Digits in a Number
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        number = Math.Abs(number);
        int originalNumber = number;
        int count = 0;

        if (number == 0) {
            count = 1;
        } else {
            while (number != 0) {
                number /= 10;
                count++;
            }
        }

        Console.WriteLine("The number {0} has {1} digits", originalNumber, count);
    }
}

// Program 3: Harshad Number Check
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;
        int originalNumber = number;

        while (number != 0) {
            sum += number % 10;
            number /= 10;
        }

        if (originalNumber % sum == 0) {
            Console.WriteLine("{0} is a Harshad Number", originalNumber);
        } else {
            Console.WriteLine("{0} is not a Harshad Number", originalNumber);
        }
    }
}

// Program 4: Abundant Number Check
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i < number; i++) {
            if (number % i == 0) {
                sum += i;
            }
        }

        if (sum > number) {
            Console.WriteLine("{0} is an Abundant Number", number);
        } else {
            Console.WriteLine("{0} is not an Abundant Number.", number);
        }
    }
}

// Program 5: Day of the Week
using System;

class DayOfWeek {
    public static void Main(string[] args) {
        int m = Convert.ToInt32(args[0]);
        int d = Convert.ToInt32(args[1]);
        int y = Convert.ToInt32(args[2]);

        if (m < 1 || m > 12 || d < 1 || d > 31) {
            Console.WriteLine("Invalid input");
            return;
        }

        int y0 = y - (14 - m) / 12;
        int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
        int m0 = m + 12 * ((14 - m) / 12) - 2;
        int d0 = (d + x + 31 * m0 / 12) % 7;

        string day = d0 switch {
            0 => "Sunday",
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday"
        };
        Console.WriteLine("{0} falls on {1}-{2}-{3}", day, d, m, y);
    }
}

// Program 6: Simple Calculator
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter the first number: ");
        double first = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the second number: ");
        double second = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        string op = Console.ReadLine();

        switch (op) {
            case "+":
                Console.WriteLine("Result: {0} + {1} = {2}", first, second, first + second);
                break;
            case "-":
                Console.WriteLine("Result: {0} - {1} = {2}", first, second, first - second);
                break;
            case "*":
                Console.WriteLine("Result: {0} * {1} = {2}", first, second, first * second);
                break;
            case "/":
                if (second != 0) {
                    Console.WriteLine("Result: {0} / {1} = {2}", first, second, first / second);
                } else {
                    Console.WriteLine("Division by zero is not allowed");
                }
                break;
            default:
                Console.WriteLine("Invalid operator! (use: +, -, *, /)");
                break;
        }
    }
}
