using System;
// Superclass Person
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Constructor
    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    // Virtual method to display the role
    public virtual void DisplayRole()
    {
        Console.WriteLine("Person");
    }

    // Method to display person details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: "+Name+", Age: "+Age);
    }
}

// Subclass Teacher
public class Teacher : Person
{
    public string Subject { get; set; }

    // Constructor 
    public Teacher(string name, int age, string subject)
        : base(name, age)
    {
        this.Subject = subject;
    }

    // Overriding the DisplayRole method
    public override void DisplayRole()
    {
        Console.WriteLine("Teacher");
    }

    // Overriding the DisplayDetails method 
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Subject: "+Subject);
    }
}

// Subclass Student
public class Student : Person
{
    public string Grade { get; set; }

    // Constructor
    public Student(string name, int age, string grade)
        : base(name, age)
    {
        this.Grade = grade;
    }

    // Overriding the DisplayRole method
    public override void DisplayRole()
    {
        Console.WriteLine("Student");
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Grade: "+Grade);
    }
}

// Subclass Staff
public class Staff : Person
{
    public string Position { get; set; }

    // Constructor
    public Staff(string name, int age, string position)
        : base(name, age)
    {
        this.Position = position;
    }

    // Overriding the DisplayRole method
    public override void DisplayRole()
    {
        Console.WriteLine("Staff");
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Position: "+Position);
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different roles
        Person teacher = new Teacher("Annu", 35, "Mathematics");
        Person student = new Student("Bobby", 15, "10th Grade");
        Person staff = new Staff("Tulshi", 40, "Administrator");

        // Storing the objects in an array of Person type
        Person[] people = { teacher, student, staff };

        // Displaying role and details
        foreach (Person person in people)
        {
            person.DisplayRole();
            person.DisplayDetails();
            Console.WriteLine();
        }
    }
}

