using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Week_4_Assignment_6_Reflection
{
    internal class AccessClass
    {
        public void UsingReflection()
        {
            Console.WriteLine("Enter the class name: ");
            string className= Console.ReadLine();
            Type type = Type.GetType(className);
            if (type == null)
            {
                Console.WriteLine("Class not found!");
                return;
            }

            Console.WriteLine($"Methods of {className}:");
            foreach (var method in type.GetMethods())
                Console.WriteLine(method.Name);

            Console.WriteLine($"\nFields of {className}:");
            foreach (var field in type.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.Static))
                Console.WriteLine(field.Name);

            Console.WriteLine($"\nConstructors of {className}:");
            foreach (var constructor in type.GetConstructors())
                Console.WriteLine(constructor);
        }
    }
}