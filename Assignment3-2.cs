// Program 1: Check Leap Year
using System;

class Solution {
    public static void CheckLeapYearUsingIfElse(int year) {
        if (year % 4 == 0) {
            if (year % 100 == 0) {
                if (year % 400 == 0) {
                    Console.WriteLine("{0} is a Leap Year", year);
                } else {
                    Console.WriteLine("{0} is not a Leap Year", year);
                }
            } else {
                Console.WriteLine("{0} is a Leap Year", year);
            }
        } else {
            Console.WriteLine("{0} is not a Leap Year", year);
        }
    }

    public static void CheckLeapYearUsingLogicalOperators(int year) {
        if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0)) {
            Console.WriteLine("{0} is a Leap Year", year);
        } else {
            Console.WriteLine("{0} is not a Leap Year", year);
        }
    }

    public static void Main() {
        Console.Write("Enter a year (>= 1582): ");
        int year = int.Parse(Console.ReadLine());

        if (year < 1582) {
            Console.WriteLine("Year must be greater than or equal to 1582.");
        } else {
            Console.WriteLine("Using multiple if-else statements:");
            CheckLeapYearUsingIfElse(year);

            Console.WriteLine("Using a single if statement with logical operators:");
            CheckLeapYearUsingLogicalOperators(year);
        }
    }
}

// Program 2: Calculate Grade and Remark
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter marks for Physics (0-100): ");
        int physics = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Chemistry (0-100): ");
        int chemistry = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter marks for Mathematics (0-100): ");
        int maths = Convert.ToInt32(Console.ReadLine());

        int totalMarks = physics + chemistry + maths;
        double percentage = totalMarks / 3.0;

        string grade = percentage switch {
            >= 80 => "A",
            >= 70 => "B",
            >= 60 => "C",
            >= 50 => "D",
            >= 40 => "E",
            _ => "R"
        };

        string remark = percentage switch {
            >= 80 => "Level 4, above agency-normalized standards",
            >= 70 => "Level 3, at agency-normalized standards",
            >= 60 => "Level 2, below, but approaching agency-normalized standards",
            >= 50 => "Level 1, well below agency-normalized standards",
            >= 40 => "Level 1-, too below agency-normalized standards",
            _ => "Remedial standards"
        };

        Console.WriteLine("Average marks: {0}", percentage);
        Console.WriteLine("Grade: {0}", grade);
        Console.WriteLine("Remark: {0}", remark);
    }
}

// Program 3: Check Prime Number
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number greater than 1: ");
        int number = Convert.ToInt32(Console.ReadLine());

        bool isPrime = true;

        for (int i = 2; i <= Math.Sqrt(number); i++) {
            if (number % i == 0) {
                isPrime = false;
                break;
            }
        }

        if (isPrime) {
            Console.WriteLine("{0} is a Prime Number", number);
        } else {
            Console.WriteLine("{0} is not a Prime Number", number);
        }
    }
}

// Program 4: FizzBuzz using for loop
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i <= number; i++) {
            if (i % 3 == 0 && i % 5 == 0) {
                Console.WriteLine("FizzBuzz");
            } else if (i % 3 == 0) {
                Console.WriteLine("Fizz");
            } else if (i % 5 == 0) {
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(i);
            }
        }
    }
}

// Program 5: FizzBuzz using while loop
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int i = 0;
        while (i <= number) {
            if (i % 3 == 0 && i % 5 == 0) {
                Console.WriteLine("FizzBuzz");
            } else if (i % 3 == 0) {
                Console.WriteLine("Fizz");
            } else if (i % 5 == 0) {
                Console.WriteLine("Buzz");
            } else {
                Console.WriteLine(i);
            }
            i++;
        }
    }
}

// Program 6: Calculate BMI
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter your weight in kilograms (kg): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your height in centimeters (cm): ");
        double heightInCm = Convert.ToDouble(Console.ReadLine());

        double heightInMeters = heightInCm / 100;
        double bmi = weight / (heightInMeters * heightInMeters);

        string weightStatus = bmi switch {
            <= 18.4 => "Underweight",
            >= 18.5 and <= 24.9 => "Normal weight",
            >= 25 and <= 39.9 => "Overweight",
            _ => "Obesity"
        };

        Console.WriteLine("BMI: {0} kg/m^2", bmi);
        Console.WriteLine("Weight Status: {0}", weightStatus);
    }
}

// Program 7: Compare Friends
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter Amar's age: ");
        int ageAmar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height (in cm): ");
        int heightAmar = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Akbar's age: ");
        int ageAkbar = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height (in cm): ");
        int heightAkbar = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter Anthony's age: ");
        int ageAnthony = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height (in cm): ");
        int heightAnthony = Convert.ToInt32(Console.ReadLine());

        string youngest = "";
        string tallest = "";

        if (ageAmar < ageAkbar && ageAmar < ageAnthony) {
            youngest = "Amar";
        } else if (ageAkbar < ageAnthony) {
            youngest = "Akbar";
        } else {
            youngest = "Anthony";
        }

        if (heightAmar > heightAkbar && heightAmar > heightAnthony) {
            tallest = "Amar";
        } else if (heightAkbar > heightAnthony) {
            tallest = "Akbar";
        } else {
            tallest = "Anthony";
        }

        Console.WriteLine("The youngest friend is {0}", youngest);
        Console.WriteLine("The tallest friend is {0}", tallest);
    }
}

// Program 8: Greatest Factor
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int greatestFactor = 1;

        for (int i = number - 1; i >= 1; i--) {
            if (number % i == 0) {
                greatestFactor = i;
                break;
            }
        }

        Console.WriteLine("The greatest factor of {0} is: {1}", number, greatestFactor);
    }
}

// Program 9: Calculate Power
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter the base number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the power: ");
        int power = Convert.ToInt32(Console.ReadLine());

        int result = 1;

        for (int i = 1; i <= power; i++) {
            result *= number;
        }

        Console.WriteLine("{0} raised to the power of {1} is: {2}", number, power, result);
    }
}

// Program 10: Factors of a Number
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The factors of {0} are:", number);
        for (int i = 1; i <= number; i++) {
            if (number % i == 0) {
                Console.WriteLine(i);
            }
        }
    }
}

// Program 11: Multiples of a Number below 100
using System;

class Solution {
    public static void Main() {
        Console.Write("Enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("The multiples of {0} below 100 are:", number);
        for (int i = 100; i >= 1; i--) {
            if (number % i == 0) {
                Console.WriteLine(i);
            }
        }
    }
}
