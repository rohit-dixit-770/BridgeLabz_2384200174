using System;
using System.Collections.Generic;

// Interface for Insurance
interface IInsurable
{
    double CalculateInsurance();
    void GetInsuranceDetails();
}

// Abstract class Vehicle
abstract class Vehicle : IInsurable
{
    public string VehicleNumber { get; protected set; }
    public string Type { get; protected set; }
    public double RentalRate { get; protected set; }

    protected Vehicle(string vehicleNumber, string type, double rentalRate)
    {
        VehicleNumber = vehicleNumber;
        Type = type;
        RentalRate = rentalRate;
    }

    public abstract double CalculateRentalCost(int days);

    // Insurance methods (default implementation)
    public virtual double CalculateInsurance()
    {
        return RentalRate * 0.05; // 5% of rental rate as insurance
    }

    public void GetInsuranceDetails()
    {
        Console.WriteLine("Insurance for " + Type + " (" + VehicleNumber + "): " + CalculateInsurance().ToString("F2"));
    }

    public void DisplayDetails()
    {
        Console.WriteLine("Vehicle: " + Type + " | Number: " + VehicleNumber + " | Rental Rate: " + RentalRate + "/day");
    }
}

// Car class
class Car : Vehicle
{
    public Car(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Car", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate;
    }
}

// Bike class
class Bike : Vehicle
{
    public Bike(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Bike", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate * 0.9; // 10% discount for bikes
    }
}

// Truck class
class Truck : Vehicle
{
    public Truck(string vehicleNumber, double rentalRate) : base(vehicleNumber, "Truck", rentalRate) { }

    public override double CalculateRentalCost(int days)
    {
        return days * RentalRate * 1.2; // 20% extra charge for trucks
    }
}

// Main class
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("CAR123", 50),
            new Bike("BIKE456", 30),
            new Truck("TRUCK789", 100)
        };

        int rentalDays = 5; // Example rental duration

        foreach (var vehicle in vehicles)
        {
            vehicle.DisplayDetails();
            Console.WriteLine("Rental Cost for " + rentalDays + " days: " + vehicle.CalculateRentalCost(rentalDays).ToString("F2"));
            vehicle.GetInsuranceDetails();
            Console.WriteLine("-----------------");
        }
    }
}
