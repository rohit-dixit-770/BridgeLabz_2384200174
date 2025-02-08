using System;
// Superclass Person
public class Person
{
    public string Name { get; set; }
    public int Id { get; set; }

    // Constructor
    public Person(string name, int id)
    {
        this.Name = name;
        this.Id = id;
    }

    // Method to display person details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Name: "+Name+", ID: "+Id);
    }
}

// Interface Worker
public interface Worker
{
    void PerformDuties(); 
}

// Subclass Chef 
public class Chef : Person, Worker
{
    // Constructor
    public Chef(string name, int id) : base(name, id) { }

    // Implementing PerformDuties method for Chef
    public void PerformDuties()
    {
        Console.WriteLine("Chef is preparing meals.");
    }

    // Overriding DisplayDetails method 
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Role: Chef");
    }
}

// Subclass Waiter 
public class Waiter : Person, Worker
{
    // Constructor
    public Waiter(string name, int id) : base(name, id) { }

    // Implementing PerformDuties method 
    public void PerformDuties()
    {
        Console.WriteLine("Waiter is serving customers.");
    }

    // Overriding DisplayDetails method 
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Role: Waiter");
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of Chef and Waiter
        Chef chef = new Chef("Mohit", 101);
        Waiter waiter = new Waiter("Bobby", 102);

        // Displaying details and performing duties
        chef.DisplayDetails();
        chef.PerformDuties();
        Console.WriteLine();

        waiter.DisplayDetails();
        waiter.PerformDuties();
    }
}

