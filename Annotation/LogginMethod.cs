using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Method)]
    public class LogExecutionTimeAttribute : Attribute
    {
        public static void MeasureExecutionTime(Action method, string methodName)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();
            method.Invoke();
            stopwatch.Stop();
            Console.WriteLine($"Execution Time of {methodName}: {stopwatch.ElapsedMilliseconds} ms");
        }
    }
    class Test
    {
        [LogExecutionTime]
        public static void Method1()
        {
            System.Threading.Thread.Sleep(500);
        }

        [LogExecutionTime]
        public static void Method2()
        {
            System.Threading.Thread.Sleep(1000);
        }

    }
    

}
