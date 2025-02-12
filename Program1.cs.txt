using System;
using System.Collections.Generic;

abstract class Employee
{
    public int EmployeeId { get; private set; }
    public string Name { get; private set; }

    public Employee(int id, string name)
    {
        EmployeeId = id;
        Name = name;
    }

    public abstract double CalculateSalary();

    public virtual void DisplayDetails()
    {
        Console.WriteLine("ID: "+EmployeeId+", Name: "+Name+", Salary: "+CalculateSalary());
    }
}

interface IDepartment
{
    void AssignDepartment(string department);
}

class FullTimeEmployee : Employee, IDepartment
{
    private double salary;
    private string department;

    public FullTimeEmployee(int id, string name, double salary) : base(id, name)
    {
        this.salary = salary;
    }

    public override double CalculateSalary()
    {
        return salary;
    }

    public void AssignDepartment(string department)
    {
        this.department = department;
    }
}

class PartTimeEmployee : Employee
{
    private double hourlyRate;
    private int hoursWorked;

    public PartTimeEmployee(int id, string name, double hourlyRate, int hoursWorked) : base(id, name)
    {
        this.hourlyRate = hourlyRate;
        this.hoursWorked = hoursWorked;
    }

    public override double CalculateSalary()
    {
        return hourlyRate * hoursWorked;
    }
}

class Program
{
    static void Main()
    {
        List<Employee> employees = new List<Employee>
        {
            new FullTimeEmployee(101, "Aman", 50000),
            new PartTimeEmployee(102, "Rahul", 20, 100)
        };

        foreach (var emp in employees)
        {
            emp.DisplayDetails();
        }
    }
}
