using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace Week_4_Assignment_6_Reflection
{
    public class SampleClassc
    {
        public void Method1()
        {
            System.Threading.Thread.Sleep(500); // Simulating work
        }

        public void Method2()
        {
            System.Threading.Thread.Sleep(300);
        }
    }
    //act like main class
    class MethodExecution
    {
        public void ExecutionMethod()
        {

            Type type = typeof(SampleClassc);
            object instance = Activator.CreateInstance(type);

            foreach (MethodInfo method in type.GetMethods(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                Stopwatch stopwatch = Stopwatch.StartNew();
                method.Invoke(instance, null);
                stopwatch.Stop();

                Console.WriteLine($"{method.Name} executed in {stopwatch.ElapsedMilliseconds} ms");
            }
        }
    }
}
