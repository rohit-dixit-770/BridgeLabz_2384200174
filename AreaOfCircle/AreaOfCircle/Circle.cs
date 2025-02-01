using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaOfCircle
{
    public class Circle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateArea()
        {
            return Math.PI * radius * radius;
        }

        public double CalculateCircumference()
        {
            return 2 * Math.PI * radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Radius: " + radius);
            Console.WriteLine("Area: " + CalculateArea());
            Console.WriteLine("Circumference: " + CalculateCircumference());
        }
    }
}
