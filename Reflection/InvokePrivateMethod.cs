using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    class Calculator
    {
        private int Multiply(int a, int b) => a * b;
    }
    internal class InvokePrivateMethod
    {
        public void Invoke()
        {
            Calculator calculator = new Calculator();
            Type type = typeof(Calculator);
            MethodInfo method = type.GetMethod("Multiply", BindingFlags.NonPublic | BindingFlags.Instance);

            if (method != null)
            {
                object result = method.Invoke(calculator, new object[] { 5, 6 });
                Console.WriteLine("Result: " + result);
            }
        }
    }
}
