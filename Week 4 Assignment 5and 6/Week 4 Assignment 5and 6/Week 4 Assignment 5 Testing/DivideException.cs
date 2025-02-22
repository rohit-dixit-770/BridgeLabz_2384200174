using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_5and6_Testing
{
    public class DivideException
    {
        public int Divide(int a, int b)
        {
            if (b == 0)
                throw new ArithmeticException("Division by zero is not allowed.");
            return a / b;
        }

    }
}

