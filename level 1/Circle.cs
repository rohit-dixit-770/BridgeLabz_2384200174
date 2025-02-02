using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Circle
    {
        public double radius;

        // Constructor chaining
        public Circle() : this(1.0) { }

        // Parameterized Constructor
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public void DisplayDetails()
        {
            Console.WriteLine("Circle Radius: " + this.radius);
        }

        public static void Main()
        {
            // create object of Circle class
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(5);

            circle1.DisplayDetails();
            circle2.DisplayDetails();
        }
    }
}
