// problem 1
using System;

public class Solution {
    public static void Main() {
        // Number of employee
        int numEmployees = 10;
        
        // declare arrays for employee detail
        double[] salary = new double[numEmployees];
        double[] yearsOfService = new double[numEmployees];
        double[] bonus = new double[numEmployees];
        double[] newSalary = new double[numEmployees];
        
        // create variable to store old salary, new salary, bonus amount
        double totalBonus = 0, totalOldSalary = 0, totalNewSalary = 0;
        
        for (int i = 0; i < numEmployees; i++) {
            // declare a variable for check valid input
            bool validInput = false;
            
            while(!validInput) {
                Console.WriteLine("Enter details for Employee {0}:", i + 1);

                // Get salary input
                Console.Write("Enter salary: ");
                salary[i] = Convert.ToDouble(Console.ReadLine());

                // Get years of service input
                Console.Write("Enter years of service: ");
                yearsOfService[i] = Convert.ToDouble(Console.ReadLine());

                // Validate Salary and years of service must be positive
                if (salary[i] > 0 && yearsOfService[i] >= 0) {
                    validInput = true; 
                } else {
                    Console.WriteLine("Invalid input");
                }
            }
            
        }
        
         // for calculate bonus, new salary, and total amounts
        for (int i = 0; i < numEmployees; i++) {
            // Calculate bonus based on years of service
            if (yearsOfService[i] > 5) {
                bonus[i] = salary[i] * 0.05;
            } else {
                bonus[i] = salary[i] * 0.02;
            }

            // calculate new salary
            newSalary[i] = salary[i] + bonus[i];

            // update total amounts
            totalBonus += bonus[i];
            totalOldSalary += salary[i];
            totalNewSalary += newSalary[i];
        }
        
        Console.WriteLine("Total Bonus Payout: {0}", totalBonus);
        Console.WriteLine("Total Old Salary: {0}", totalOldSalary);
        Console.WriteLine("Total New Salary: {0}", totalNewSalary);
    }
}






// problem 2

using System;

class Solution {
    public static void Main() {
        // Declare arrays for storing the ages and heights of the 3 friends
        int[] age = new int[3];
        double[] height = new double[3];
        string[] name = { "Amar", "Akbar", "Anthony" };

        // get input for ages and heights of the three friends
        Console.WriteLine("Enter the details for the three friends:");

        // input for Amar
        Console.Write("Enter Amar's age: ");
        age[0] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Amar's height (in cm): ");
        height[0] = Convert.ToDouble(Console.ReadLine());

        // input for Akbar
        Console.Write("Enter Akbar's age: ");
        age[1] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Akbar's height (in cm): ");
        height[1] = Convert.ToDouble(Console.ReadLine());

        // input for Anthony
        Console.Write("Enter Anthony's age: ");
        age[2] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter Anthony's height (in cm): ");
        height[2] = Convert.ToDouble(Console.ReadLine());
        
        // declare a youngest variable
        int youngestIndex = 0;
        // create a loop to find youngest friend
        for (int i = 1; i < 3; i++) {
            if (age[i] < age[youngestIndex]) {
                youngestIndex = i;
            }
        }
        
        // create a variable for tallest 
        int tallestIndex = 0;
        // loop for find tallest Index
        for (int i = 1; i < 3; i++ ) {
            if(height[i] > height[tallestIndex]) {
                tallestIndex = i;
            }
        }
        
        // print output
        Console.WriteLine("{0} is youngest friend his age is {1}", name[youngestIndex], age[youngestIndex]);
        Console.WriteLine("{0} is tallest friend his height is {1}", name[tallestIndex], height[tallestIndex]);
        
    }       
}









// problem 3

using System;

class Solution {
    public static void Main() {
        // Declare all variable and array
        int maxDigit = 10;
        int []digit = new int[maxDigit];
        int index = 0;
        
        Console.Write("Enter number : ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // for storing digit in array
        while(number != 0 || index < maxDigit) {
            int rem = number % 10; 
            number /= 10; 
            digit[index++] = rem; 
        }
        
        // declare largest and secondLargest variable
        int largest = -1, secondLargest = -1; 
        
        // create loop for find largest and secondLargest value
        for (int i = 0; i < index; i++) {
            if(digit[i] > largest) {
                secondLargest = largest;
                largest = digit[i];
            } else if (digit[i] > secondLargest && digit[i] < largest) { 
                secondLargest = digit[i];
            }
        }
		
        // print largest digit
        if(largest != -1) {
            Console.WriteLine("Largest digit is {0}", largest);
        } else {
            Console.WriteLine("No largest digit found ");
        }
        
        // print second Largest digit
        if (secondLargest != -1) {
            Console.WriteLine("Second largest digit is {0}", secondLargest);
        } else {
            Console.WriteLine("No second largest digit found ");
        }      
    }    
}








// problem 4

using System;

class Solution {
    public static void Main() {
        // Declare all variable and array
        int maxDigit = 10;
        int []digit = new int[maxDigit];
        int index = 0;
        
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // for storing digit in array
        while(number != 0 ) {
            if (index == maxDigit) {
                // If the array is full, increase the size by 10
                maxDigit += 10;

                // Create a temporary array with the new size
                int[] temp = new int[maxDigit];

                // Copy existing digits into the new temp array
                Array.Copy(digit, temp, digit.Length);

                // Reassign the digits array to point to the new temp array
                digit = temp;
            }
            int rem = number % 10; 
            number /= 10; 
            digit[index++] = rem; 
        }
        
        // declare largest and secondLargest variable
        int largest = -1, secondLargest = -1; 
        
        // create loop for find largest and secondLargest value
        for (int i = 0; i < index; i++) {
            if(digit[i] > largest) {
                secondLargest = largest;
                largest = digit[i];
            } else if (digit[i] > secondLargest && digit[i] < largest) { 
                secondLargest = digit[i];
            }
        }
        // print largest digit
        if(largest != -1) {
            Console.WriteLine("Largest digit is {0}", largest);
        } else {
            Console.WriteLine("No largest digit found ");
        }
        
        // print second Largest digit
        if (secondLargest != -1) {
            Console.WriteLine("Second largest digit is {0}", secondLargest);
        } else {
            Console.WriteLine("No second largest digit found ");
        }
        
    }    
}








// problem 5

using System;

class Solution {
    public static void Main() {
        // take user input
        Console.Write("Enter a positive number: ");
        int number = Convert.ToInt32(Console.ReadLine());
        
        // find the count of digits 
        int temp = number;
        int digitCount = 0;

        // Count the digits 
        while (temp != 0) {
            digitCount++;
            temp /= 10;
        }
        
        // Create an array to store the digits in reverse order
        int[] digits = new int[digitCount];
        temp = number; 

        // store the digits in an array
        for (int i = 0; i < digitCount; i++) {
            digits[i] = temp % 10;
            temp /= 10;
        }

        Console.WriteLine("Reversed number:");
        for (int i = 0; i < digits.Length; i++) {
            Console.Write(digits[i]);
        }
    }
}








// problem 6

using System;

class Solution {
    public static void Main() {
        // Prompt the user for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Initialize arrays to store height, weight, BMI, and weight status
        double[] weights = new double[numPersons];
        double[] heights = new double[numPersons];
        double[] bmis = new double[numPersons];
        string[] weightStatuses = new string[numPersons];

        // Take input for height and weight for each person
        for (int i = 0; i < numPersons; i++) {
            Console.Write("Enter weight of person {0} in kilograms (kg): ", i + 1);
            weights[i] = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter height of person {0} in centimeters (cm): ", i + 1);
            heights[i] = Convert.ToDouble(Console.ReadLine());
        }

        // Calculate BMI and determine weight status for each person
        for (int i = 0; i < numPersons; i++) {
            double heightInMeters = heights[i] / 100; 
            bmis[i] = weights[i] / (heightInMeters * heightInMeters);

            // Determine weight status based on BMI
            weightStatuses[i] = bmis[i] switch {
                <= 18.4 => "Underweight",
                >= 18.5 and <= 24.9 => "Normal",
                >= 25 and <= 39.9 => "Overweight",
                >=40 => "Obese"
            };
        }

        // Display the results for each person
        for (int i = 0; i < numPersons; i++) {
            Console.WriteLine("person {0} has : height={1}, wieght={2}, bmi={3}, weightStatuse={4}", i+1, heights[i], weights[i], bmis[i], weightStatuses[i]);
        }
    }
}









// problem 7

using System;

class Solution {
    public static void Main() {
        // Prompt the user for the number of persons
        Console.Write("Enter the number of persons: ");
        int numPersons = int.Parse(Console.ReadLine());

        // Initialize a 2D array to store height, weight, and BMI
        double[,] personData = new double[numPersons, 3]; // [height, weight, BMI]
        string[] weightStatuses = new string[numPersons];

        // Take input for height and weight for each person
        for (int i = 0; i < numPersons; i++) {
			Console.Write("Enter height of person {0} in centimeters (cm): ", i + 1);
            personData[i, 0] = Convert.ToDouble(Console.ReadLine());
		
            Console.Write("Enter weight of person {0} in kilograms (kg): ", i + 1);
            personData[i, 1] = Convert.ToDouble(Console.ReadLine());    
        }

        // Calculate BMI and determine weight status for each person
        for (int i = 0; i < numPersons; i++) {
            double heightInMeters = personData[i, 0] / 100;
            personData[i, 2] = personData[i, 1] / (heightInMeters * heightInMeters); 

            // Determine weight status based on BMI
            double bmi = personData[i, 2];
            weightStatuses[i] = bmi switch {
                <= 18.4 => "Underweight",
                >= 18.5 and <= 24.9 => "Normal",
                >= 25 and <= 29.9 => "Overweight",
                >=40 => "Obese"
            };
        }

        // Display the results for each person
		for (int i = 0; i < numPersons; i++) {
            Console.WriteLine("person {0} has : height={1}, wieght={2}, bmi={3}, weightStatuse={4}", i+1, personData[i, 0], personData[i, 1], personData[i, 2], weightStatuses[i]);
        }
    }
}









// problem 8

using System;

class Solution {
    public static void Main() {
        // Prompt for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Initialize arrays to store marks, percentages, and grades
        int[] physicsMarks = new int[numStudents];
        int[] chemistryMarks = new int[numStudents];
        int[] mathematicsMarks = new int[numStudents];
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Entering marks for student {0}:", i + 1);

            Console.Write("Enter marks for Physics out of 100: ");
            physicsMarks[i] = Convert.ToInt32(Console.ReadLine());
			
            while (physicsMarks[i] < 0 || physicsMarks[i] > 100) {
                Console.WriteLine("Marks must be between 0 and 100");
                Console.Write("Enter marks for Physics out of 100: ");
                physicsMarks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter marks for Chemistry out of 100: ");
            chemistryMarks[i] = Convert.ToInt32(Console.ReadLine());
			
            while (chemistryMarks[i] < 0 || chemistryMarks[i] > 100) {
                Console.WriteLine("Marks must be between 0 and 100");
                Console.Write("Enter marks for Chemistry out of 100: ");
                chemistryMarks[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Enter marks for Mathematics out of 100: ");
            mathematicsMarks[i] = Convert.ToInt32(Console.ReadLine());
			
            while (mathematicsMarks[i] < 0 || mathematicsMarks[i] > 100) {
                Console.WriteLine("Marks must be between 0 and 100");
                Console.Write("Enter marks for Mathematics out of 100: ");
                mathematicsMarks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Calculate percentages and grades for each student
        for (int i = 0; i < numStudents; i++) {
            int totalMarks = physicsMarks[i] + chemistryMarks[i] + mathematicsMarks[i];
            percentages[i] = totalMarks / 3.0;

            grades[i] = percentages[i] switch {
                >= 80 => "A",
                >= 70 => "B",
                >= 60 => "C",
                >= 50 => "D",
                >= 40 => "E",
                _ => "R"
            };
        }

        // Display results for each student
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("student {0} scored physics={1}, chemistry={2}, mathematics={3} and percentage={4} with grade={5}", i + 1, physicsMarks[i], chemistryMarks[i], mathematicsMarks[i], percentages[i], grades[i]);
        }
    }
}










// problem 9

using System;

class Solution {
    public static void Main() {
        // Prompt for the number of students
        Console.Write("Enter the number of students: ");
        int numStudents = Convert.ToInt32(Console.ReadLine());

        // Initialize arrays to store marks, percentages, and grades
        int[,] marks = new int[numStudents, 3]; 
        double[] percentages = new double[numStudents];
        string[] grades = new string[numStudents];

        // Input marks for each student
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("Entering marks for student {0}:", i + 1);

            for (int j = 0; j < 3; j++) {
                string subject = j switch {
                    0 => "Physics",
                    1 => "Chemistry",
                    _ => "Mathematics"
                };

                Console.Write("Enter marks for {0} out of 100: ", subject);
                marks[i, j] = Convert.ToInt32(Console.ReadLine());

                while (marks[i, j] < 0 || marks[i, j] > 100) {
                    Console.WriteLine("Marks must be between 0 and 100");
                    Console.Write("Enter marks for {0} out of 100: ", subject);
                    marks[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
        }

        // Calculate percentages and grades for each student
        for (int i = 0; i < numStudents; i++) {
            int totalMarks = marks[i, 0] + marks[i, 1] + marks[i, 2];
            percentages[i] = totalMarks / 3.0;

            grades[i] = percentages[i] switch {
                >= 80 => "A",
                >= 70 => "B",
                >= 60 => "C",
                >= 50 => "D",
                >= 40 => "E",
                _ => "R"
            };
        }

        // Display results for each student
        for (int i = 0; i < numStudents; i++) {
            Console.WriteLine("student {0} scored physics={1}, chemistry={2}, mathematics={3} and percentage={4} with grade={5}", i + 1, marks[i, 0], marks[i, 1], marks[i, 2], percentages[i], grades[i]);
        }
    }
}









// problem 10

using System;

class Solution {
    public static void Main() {
        // Prompt for the input number
        Console.Write("Enter number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        // Initialize the frequency array
        int[] frequency = new int[10];

        // Calculate the frequency of each digit
        while (number > 0) {
            int digit = number % 10;
            frequency[digit]++;
            number /= 10;
        }

        // printing result
        for (int i = 0; i < 10; i++) {
            if (frequency[i] > 0) {
                Console.WriteLine("{0} occured {1} times", i, frequency[i]);
            }
        }
    }
}
