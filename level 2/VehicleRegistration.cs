using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Vehicle
    {
        public string ownerName { get; set; }
        public string vehicleType { get; set; }
        public static double registrationFee = 500.0;

        public Vehicle(string ownerName, string vehicleType)
        {
            this.ownerName = ownerName;
            this.vehicleType = vehicleType;
        }

        public void DisplayVehicleDetails()
        {
            Console.WriteLine($"Owner: {this.ownerName}, Vehicle Type: {this.vehicleType}, Registration Fee: {Vehicle.registrationFee}");
        }

        public static void UpdateRegistrationFee(double newFee)
        {
            Vehicle.registrationFee = newFee;
        }

        public static void Main()
        {
            Vehicle vehicle = new Vehicle("Rohit" , "Two veehler");

            vehicle.DisplayVehicleDetails();
            Vehicle.registrationFee = 1000;
            Console.WriteLine($"Modified Registration fee is {Vehicle.registrationFee}");

        }
    }
}

