using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]    
    class ImportantMethod : Attribute
    {
        public string Level { get; }
        public ImportantMethod(string level)
        {
            this.Level = level;
        }
    }

    class SampleClass
    {
        [ImportantMethod("HIGH")]
        public void CriticalMethod()
        {
            Console.WriteLine("Executing Critical Method");
        }

        [ImportantMethod("MEDIUM")]
        public void SecondaryMethod()
        {
            Console.WriteLine("Executing Secondary Method");
        }

        public void RegularMethod()
        {
            Console.WriteLine("Executing Regular Method");
        }
    }


    class Check1
    {
        public void Check1Data()
        {
            Type type = typeof(SampleClass);
            foreach (MethodInfo method in type.GetMethods())
            {
                var attribute = (ImportantMethod)Attribute.GetCustomAttribute(method, typeof(ImportantMethod));
                if (attribute != null)
                {
                    Console.WriteLine($"Method: {method.Name}, Importance Level: {attribute.Level}");
                }
            }
        }
    }
}
