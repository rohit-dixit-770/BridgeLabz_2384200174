using System;
// Base class Employee
public class Employee
{
    
    public string Name { get; set; }
    public int Id { get; set; }
    public double Salary { get; set; }

    // Constructor
    public Employee(string name, int id, double salary)
    {
        this.Name = name;
        this.Id = id;
        this.Salary = salary;
    }

    // Method to display Employee details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: "+Name+", Id: "+Id+", Salary: "+Salary);
    }
}

// Subclass Manager
public class Manager : Employee
{
    public int TeamSize { get; set; }

    // Constructor 
    public Manager(string name, int id, double salary, int teamSize) 
        : base(name, id, salary)
    {
        this.TeamSize = teamSize;
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Team Size: "+TeamSize);
    }
}

// Subclass Developer
public class Developer : Employee
{
    public string ProgrammingLanguage { get; set; }

    // Constructor
    public Developer(string name, int id, double salary, string programmingLanguage)
        : base(name, id, salary)
    {
        this.ProgrammingLanguage = programmingLanguage;
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Programming Language: "+ProgrammingLanguage);
    }
}

// Subclass Intern
public class Intern : Employee
{
    public string InternshipDuration { get; set; }

    // Constructor 
    public Intern(string name, int id, double salary, string internshipDuration)
        : base(name, id, salary)
    {
        this.InternshipDuration = internshipDuration;
    }

    // Overriding the DisplayDetails method
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Internship Duration: "+InternshipDuration);
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different employee types
        Employee manager = new Manager("Abhishek", 101, 95000, 10);
        Employee developer = new Developer("Bobby", 102, 80000, "C#");
        Employee intern = new Intern("Tushar", 103, 40000, "6 months");

        // Displaying details of each employee
        manager.DisplayDetails();
        Console.WriteLine();

        developer.DisplayDetails();
        Console.WriteLine();

        intern.DisplayDetails();
    }
}
