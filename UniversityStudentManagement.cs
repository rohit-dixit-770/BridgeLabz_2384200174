using System;

class Student
{
    // Static variable 
    private static string universityName = "GLA University";
    private static int StudentCount = 0;

    // Readonly variable
    private readonly int rollNumber;
    
    // Instance variables 
    private string name;
    private char grade;

    // Constructor 
    public Student(string name, int rollNumber, char grade)
    {
        this.name = name;
        this.rollNumber = rollNumber;
        this.grade = grade;
        StudentCount++; 
    }

    // Static method to display total students
    public static void DisplayTotalStudents()
    {
        Console.WriteLine("Total Students Enrolled: " + StudentCount);
    }

    // Method to update student grade
    public void UpdateGrade(char newGrade)
    {
        if (this is Student)
        {
            this.grade = newGrade;
            Console.WriteLine("grade updated successfully for Roll Number: " + this.rollNumber);
        }
        else
        {
            Console.WriteLine("Invalid student");
        }
    }

    // Method to display student details
    public void DisplayStudentDetails()
    {
        if (this is Student)
        {
            Console.WriteLine("name: " + this.name);
            Console.WriteLine("Roll Number: " + this.rollNumber);
            Console.WriteLine("grade: " + this.grade);
        }
        else
        {
            Console.WriteLine("Invalid student");
        }
    }
	
	public static void Main()
    {
        // Display university name
        Console.WriteLine("University: " + "GLA University");
        
        // Creating student instances
        Student student = new Student("Rohit", 174 , 'O');
        
        // Displaying student details
        student.DisplayStudentDetails();
        
        // Updating student grade
        student.UpdateGrade('A');
        
        // Displaying total students 
        Student.DisplayTotalStudents();
    }
}
