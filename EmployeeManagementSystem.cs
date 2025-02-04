using System;

class Employee
{
    // Static variable 
    private static string companyName = "Capgemini";
    
    // Static variable 
    private static int EmployeCount = 0;

    // Readonly variable 
    private readonly int id;
    
    // Instance variables 
    private string name;
    private string designation;

    // Constructor 
    public Employee(int id, string name, string designation)
    {
        this.id = id;
        this.name = name;
        this.designation = designation;
        EmployeCount++; 
    }   

    // Method to display company name
    public void DisplayCompanyname()
    {
        Console.WriteLine("Company Name :" + companyName);
    }

    // Method to display employee details
    public void DisplayEmployeeDetails()
    {
        if (this is Employee)
        {
            Console.WriteLine("Name: " + this.name);
            Console.WriteLine("ID: " + this.id);
            Console.WriteLine("Designation: " + this.designation);
        }
        else
        {
            Console.WriteLine("Invalid employee");
        }
    }
	
	public static void Main()
	{
		// Creating employee instances
        Employee emp = new Employee(101, "Rohit", "Software Engineer");
        
        // Display company name
        emp.DisplayCompanyname();
        
        // Display employee details
        emp.DisplayEmployeeDetails();
	}
}