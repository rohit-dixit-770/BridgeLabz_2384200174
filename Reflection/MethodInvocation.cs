using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    class MathOperation
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Subtract(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
    }
    class CallMethod
    {
        public void AnyMethod()
        {
            MathOperation mathOps = new MathOperation();
            Console.Write("Enter method name (Add, Subtract, Multiply): ");
            string methodName = Console.ReadLine();

            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            MethodInfo method = typeof(MathOperation).GetMethod(methodName);
            if (method != null)
            {
                object result = method.Invoke(mathOps, new object[] { num1, num2 });
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid method name!");
            }
        }
    }

}
