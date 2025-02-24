using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited= true)]   
    public class BugReport : Attribute
    {
        public string Description { get; }

        public BugReport(string description)
        {
            Description = description;
        }
    }

    // Apply BugReport attribute multiple times to a method
    public class TestClass
    {
        [BugReport("Bug 1: Fix null reference issue.")]
        [BugReport("Bug 2: Improve performance.")]
        public void TestMethod()
        {
            Console.WriteLine("Executing TestMethod...");
        }
    }

    class Check
    {
        public void CheckData()
        {
            MethodInfo methodInfo = typeof(TestClass).GetMethod("TestMethod");
            var bugReports = methodInfo.GetCustomAttributes<BugReport>();

            Console.WriteLine("Bug Reports:");
            foreach (var bug in bugReports)
            {
                Console.WriteLine($"- {bug.Description}");
            }
        }
    }


}
