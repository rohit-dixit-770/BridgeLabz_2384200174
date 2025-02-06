using System;
using System.Collections.Generic;

// Student class
class Student
{
    public string name;
    private List<Course> enrolledCourses; 

    // Constructor 
    public Student(string name)
    {
       this. name = name;
        this.enrolledCourses = new List<Course>();
    }

    // Method to enroll a student
    public void EnrollCourse(Course course)
    {
        enrolledCourses.Add(course);
        course.AddStudent(this);
    }

    // Method to display all courses 
    public void DisplayCourses()
    {
        Console.WriteLine("Student: {0} is enrolled in:", name);
        foreach (var course in enrolledCourses)
        {
            Console.WriteLine("- {0}", course.courseName);
        }
    }
}

// Professor class 
class Professor
{
    public string name;

    // Constructor
    public Professor(string name)
    {
        this.name = name;
    }
}

// Course class 
class Course
{
    public string courseName;
    private List<Student> students;
    public Professor assignedProfessor;

    // Constructor
    public Course(string courseName)
    {
        this.courseName = courseName;
        this.students = new List<Student>();
    }

    // Method to assign a professor
    public void AssignProfessor(Professor professor)
    {
        assignedProfessor = professor;
    }

    // Method to add a student
    public void AddStudent(Student student)
    {
        students.Add(student);
    }

    // Method to display course details
    public void DisplayCourseInfo()
    {
        Console.WriteLine("Course: {0}", this.courseName);
        Console.WriteLine("Professor: {0}", assignedProfessor.name);
        Console.WriteLine("Enrolled Students:");
        foreach (var student in students)
        {
            Console.WriteLine("{0}", student.name);
        }
    }
}

// Main Class
class Program
{
    static void Main()
    {
        // Creating student object
        Student student1 = new Student("Rohit");
        Student student2 = new Student("Mohit");
        
        // Creating professor object
        Professor professor = new Professor("Dr. KashiNath");
        
        // Creating course object
        Course course = new Course("Data Structure");
        course.AssignProfessor(professor);
        
        // Enrolling students 
        student1.EnrollCourse(course);
        student2.EnrollCourse(course);
        
        // Displaying course information
        course.DisplayCourseInfo();
    }
}
