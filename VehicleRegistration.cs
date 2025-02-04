using System;

class Vehicle
{
    // Static variable 
    public static double registrationFee = 5000;
    
    // Readonly variable
    public readonly string registrationNumber;
    
    // Instance variables
    public string ownerName;
    public string vehicleType;

    // Constructor 
    public Vehicle(string ownerName, string vehicleType, string registrationNumber)
    {
        this.ownerName = ownerName;
        this.vehicleType = vehicleType;
        this.registrationNumber = registrationNumber;
    }

    // Static method to update registration fee
    public static void UpdateregistrationFee(double newFee)
    {
        registrationFee = newFee;
    }

    // Method to display vehicle details
    public void DisplayDetails()
    {
        if (this is Vehicle) 
        {
            Console.WriteLine($"Owner: {ownerName}");
            Console.WriteLine($"Type: {vehicleType}");
            Console.WriteLine($"Registration Number: {registrationNumber}");
            Console.WriteLine($"Registration Fee: {registrationFee}");
        }
    }

    public static void Main()
    {
        // Creating vehicle instances
        Vehicle car = new Vehicle("Rohit", "Car", "ABC1234");
        Vehicle bike = new Vehicle("Rahul", "Bike", "XYZ5678");

        car.DisplayDetails();
        bike.DisplayDetails();
        
        // Update Registration Fee
        Vehicle.UpdateregistrationFee(5500);
        
        Console.WriteLine("After Updating Registration Fee:");
        car.DisplayDetails();
        bike.DisplayDetails();
    }
}


