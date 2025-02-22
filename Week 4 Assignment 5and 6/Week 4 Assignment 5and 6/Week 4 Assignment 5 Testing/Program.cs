using System;
using Week_4_Assignment_5and6_Testing;

class Assignment_5
{
    public static void Main(string[] args)
    { 
        //------------------------------------------------------------------------------------
        try
        {
            Calculator calculator = new Calculator();
            Console.WriteLine("Enter the first number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number : ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            calculator.Add(number1, number2);
            calculator.Subtract(number1, number2);
            calculator.Divide(number1, number2);
            calculator.Multiply(number1, number2);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine(e.Message);
        }


        //--------------------------------------------------------------------------------



    }
}