using System;
using NUnit.Framework;
using Week_4_Assignment_5and6_Testing;
namespace testUnit
{
    [TestFixture]
    public class CalculatorTests
    {
        private Calculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new Calculator();
        }

        [Test]
        public void Add_TwoNumbers_ReturnsSum()
        {
            Assert.AreEqual(5, calculator.Add(2, 3));
        }

        [Test]
        public void Subtract_TwoNumbers_ReturnsDifference()
        {
            Assert.AreEqual(1, calculator.Subtract(4, 3));
        }

        [Test]
        public void Multiply_TwoNumbers_ReturnsProduct()
        {
            Assert.AreEqual(6, calculator.Multiply(2, 3));
        }

        [Test]
        public void Divide_TwoNumbers_ReturnsQuotient()
        {
            Assert.AreEqual(2, calculator.Divide(6, 3));
        }

        [Test]
        public void Divide_ByZero_ThrowsException()
        {
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(6, 0));
        }
    }
}
