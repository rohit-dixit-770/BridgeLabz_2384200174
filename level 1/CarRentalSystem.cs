using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class CarRental
    {
        public string customerName;
        public string carModel;
        public int rentalDays;
        public double costPerDay  = 5000.0; 

        public CarRental(string customerName, string carModel, int rentalDays)
        {
            this.customerName = customerName;
            this.carModel = carModel;
            this.rentalDays = rentalDays;
        }

        public double CalculateTotalCost()
        {
            return this.rentalDays * this.costPerDay;
        }


        public static void Main()
        {
            // create object of CarRental class
            CarRental cr = new CarRental("Rohit" , "FERRARI - SF90XX", 5);

            Console.WriteLine($"Total rent is {cr.CalculateTotalCost()}");
        }
    }

}
