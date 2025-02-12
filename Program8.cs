using System;
using System.Collections.Generic;

// Abstract class Vehicle
abstract class Vehicle
{
    public string DriverName { get; set; }
    public double RatePerKm { get; set; }

    public Vehicle(string driverName, double ratePerKm)
    {
        DriverName = driverName;
        RatePerKm = ratePerKm;
    }

    public abstract double CalculateFare(double distance);
}

// Car class
class Car : Vehicle
{
    public Car(string driverName, double ratePerKm) : base(driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

// Bike class
class Bike : Vehicle
{
    public Bike(string driverName, double ratePerKm) : base(driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

// Auto class
class Auto : Vehicle
{
    public Auto(string driverName, double ratePerKm) : base(driverName, ratePerKm) { }

    public override double CalculateFare(double distance)
    {
        return distance * RatePerKm;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        List<Vehicle> vehicles = new List<Vehicle>
        {
            new Car("Aman", 10),
            new Bike("Rahul", 5),
            new Auto("Kartik", 7)
        };

        double distance = 15; // Example distance

        foreach (var vehicle in vehicles)
        {
            Console.WriteLine("Driver: " + vehicle.DriverName + ", Fare for " + distance + " km: " + vehicle.CalculateFare(distance));
        }
    }
}
