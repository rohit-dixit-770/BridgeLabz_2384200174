using System;

class ProblemSolutions{

    public void PrintBridgeLabz(){
        Console.WriteLine("Welcome to Bridgelabz!");
    }

    public void AddTwoNumbers(){
        Console.Write("Enter the first number: ");
        int number1 = int.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        int number2 = int.Parse(Console.ReadLine());
        int sum = number1 + number2;
        Console.WriteLine("The sum is: " + sum);
    }

    public void ConvertCelsiusToFahrenheit(){
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine("Temperature in Fahrenheit: " + fahrenheit);
    }

    public void CalculateAreaOfCircle(){
        Console.Write("Enter the radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = Math.PI * Math.Pow(radius, 2);
        Console.WriteLine("The area of the circle is: " + area);
    }

    public void CalculateVolumeOfCylinder(){
        Console.Write("Enter the radius of the cylinder: ");
        double radius = double.Parse(Console.ReadLine());
        Console.Write("Enter the height of the cylinder: ");
        double height = double.Parse(Console.ReadLine());
        double volume = Math.PI * Math.Pow(radius, 2) * height;
        Console.WriteLine("The volume of the cylinder is: " + volume);
    }

    public void CalculateSimpleInterest(){
        Console.Write("Enter the principal amount: ");
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter the rate of interest: ");
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter the time in years: ");
        double time = double.Parse(Console.ReadLine());
        double simpleInterest = (principal * rate * time) / 100;
        Console.WriteLine("The simple interest is: " + simpleInterest);
    }

    public void CalculatePerimeterOfRectangle(){
        Console.Write("Enter the length of the rectangle: ");
        double length = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectangle: ");
        double width = double.Parse(Console.ReadLine());
        double perimeter = 2 * (length + width);
        Console.WriteLine("The perimeter of the rectangle is: " + perimeter);
    }

    public void CalculatePower(){
        Console.Write("Enter the base number: ");
        double baseNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter the power: ");
        double power = double.Parse(Console.ReadLine());
        double result = Math.Pow(baseNumber, power);
        Console.WriteLine("The result is: " + result);
    }

    public void CalculateAverage(){
        Console.Write("Enter the first number: ");
        double number1 = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double number2 = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double number3 = double.Parse(Console.ReadLine());
        double average = (number1 + number2 + number3) / 3;
        Console.WriteLine("The average is: " + average);
    }

    public void ConvertKilometersToMiles(){
        Console.Write("Enter distance in kilometers: ");
        double kilometers = double.Parse(Console.ReadLine());
        double miles = kilometers * 0.621371;
        Console.WriteLine("The distance in miles is: " + miles);
    }
}

class ProblemStatement{
    public static void Main(string[] args){
        ProblemSolutions PS = new ProblemSolutions();

        // 1. Welcome to Bridgelabz!
        PS.PrintBridgeLabz();

        // 2. Add Two Numbers
        PS.AddTwoNumbers();

        // 3. Celsius to Fahrenheit Conversion
        PS.ConvertCelsiusToFahrenheit();

        // 4. Area of a Circle
        PS.CalculateAreaOfCircle();

        // 5. Volume of a Cylinder
        PS.CalculateVolumeOfCylinder();

        // Self Problems

        // 1. Calculate Simple Interest
        PS.CalculateSimpleInterest();

        // 2. Perimeter of a Rectangle
        PS.CalculatePerimeterOfRectangle();

        // 3. Power Calculation
        PS.CalculatePower();

        // 4. Calculate Average of Three Numbers
        PS.CalculateAverage();

        // 5. Convert Kilometers to Miles
        PS.ConvertKilometersToMiles();
    }
}
