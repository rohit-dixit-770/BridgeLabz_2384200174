using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week_4_Assignment_5and6_Testing;

namespace testUnit
{
    public class PerformanceTests
    {
        TImeOutProblem timeout;
        [SetUp]
        public void SetUp()
        {
            timeout = new TImeOutProblem();
        }

        [Test, Timeout(2000)] // Fails if execution takes more than 2 seconds
        public void LongRunningTask_ShouldFailDueToTimeout()
        {
            var result = timeout.LongRunningTask();
            Assert.AreEqual("Completed", result);
        }
    }
}
