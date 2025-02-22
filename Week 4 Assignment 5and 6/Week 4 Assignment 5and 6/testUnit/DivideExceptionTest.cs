using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    internal class DivideExceptionTest
    {
       
            [Test]
            public void Divide_ByZero_ThrowsArithmeticException()
            {
                // Arrange
                var divideException = new DivideException();

                // Act & Assert
                Assert.Throws<ArithmeticException>(() => divideException.Divide(10, 0));
            }
        
    }
}
