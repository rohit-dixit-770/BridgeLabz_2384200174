using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    internal class CheckEvenTest
    {
        CheckEven checkEven;
        [SetUp]
        public void SetUp()
        {
            checkEven = new CheckEven();
        }
            [TestCase(2, ExpectedResult = true)]
            [TestCase(4, ExpectedResult = true)]
            [TestCase(6, ExpectedResult = true)]
            [TestCase(7, ExpectedResult = false)]
            [TestCase(9, ExpectedResult = false)]
            public bool IsEven_TestCases(int number)
            {
                return checkEven.IsEven(number);
            }
        
    }
}
