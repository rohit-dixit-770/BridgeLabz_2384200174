using System;
// Base class Vehicle
public class Vehicle
{
    public int MaxSpeed { get; set; }
    public string FuelType { get; set; }

    // Constructor 
    public Vehicle(int maxSpeed, string fuelType)
    {
        this.MaxSpeed = maxSpeed;
        this.FuelType = fuelType;
    }

    // Method to display Vehicle information
    public virtual void DisplayInfo()
    {
        Console.WriteLine(""+MaxSpeed+", Fuel Type: "+FuelType);
    }
}

// Subclass Car
public class Car : Vehicle
{
    public int SeatCapacity { get; set; }

    // Constructor
    public Car(int maxSpeed, string fuelType, int seatCapacity)
        : base(maxSpeed, fuelType)
    {
        this.SeatCapacity = seatCapacity;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Seat Capacity: "+SeatCapacity);
    }
}

// Subclass Truck
public class Truck : Vehicle
{
    public int PayloadCapacity { get; set; }

    // Constructor 
    public Truck(int maxSpeed, string fuelType, int payloadCapacity)
        : base(maxSpeed, fuelType)
    {
        this.PayloadCapacity = payloadCapacity;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Payload Capacity: "+PayloadCapacity);
    }
}

// Subclass Motorcycle
public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    // Constructor
    public Motorcycle(int maxSpeed, string fuelType, bool hasSidecar)
        : base(maxSpeed, fuelType)
    {
        this.HasSidecar = hasSidecar;
    }

    // Overriding the DisplayInfo method
    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine("Has Sidecar: "+HasSidecar);
    }
}

// Main program
class Program
{
    static void Main(string[] args)
    {
        // Creating instances of different vehicle types
        Vehicle car = new Car(180, "Petrol", 6);
        Vehicle truck = new Truck(120, "Diesel", 2500);
        Vehicle motorcycle = new Motorcycle(150, "Petrol", true);

        // Storing the objects in an array of Vehicle type
        Vehicle[] vehicles = { car, truck, motorcycle };

        // Calling the DisplayInfo method on each object in the array
        foreach (Vehicle vehicle in vehicles)
        {
            vehicle.DisplayInfo();
            Console.WriteLine();
        }
    }
}
