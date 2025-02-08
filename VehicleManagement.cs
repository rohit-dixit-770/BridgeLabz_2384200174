using System;
// Superclass Vehicle
public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string Model { get; set; }

    // Constructor
    public Vehicle(int maxSpeed, string model)
    {
        this.MaxSpeed = maxSpeed;
        this.Model = model;
    }

    // Method to display vehicle details
    public virtual void DisplayDetails()
    {
        Console.WriteLine("Model: "+Model+", Max Speed: "+MaxSpeed+" km/h");
    }
}

// Interface Refuelable
public interface Refuelable
{
    void Refuel(); 

// Subclass ElectricVehicle 
public class ElectricVehicle : Vehicle
{
    public ElectricVehicle(int maxSpeed, string model)
        : base(maxSpeed, model) { }

    // Method to charge the electric vehicle
    public void Charge()
    {
        Console.WriteLine("Charging electric vehicle...");
    }

    // Overriding the DisplayDetails method 
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Electric");
    }
}

// Subclass PetrolVehicle 
public class PetrolVehicle : Vehicle, Refuelable
{
    // Constructor 
    public PetrolVehicle(int maxSpeed, string model)
        : base(maxSpeed, model) { }

    // Implementing the Refuel method 
    public void Refuel()
    {
        Console.WriteLine("Refueling petrol vehicle...");
    }

    // Overriding the DisplayDetails method 
    public override void DisplayDetails()
    {
        base.DisplayDetails();
        Console.WriteLine("Vehicle Type: Petrol");
    }
}

// Main program 
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of ElectricVehicle and PetrolVehicle
        ElectricVehicle electricVehicle = new ElectricVehicle(140, "Tesla Model S");
        PetrolVehicle petrolVehicle = new PetrolVehicle(160, "Toyota Corolla");

        // Displaying details and performing specific actions
        electricVehicle.DisplayDetails();
        electricVehicle.Charge();
        Console.WriteLine();

        petrolVehicle.DisplayDetails();
        petrolVehicle.Refuel();
    }
}

