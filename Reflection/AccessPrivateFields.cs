using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    class Person
    {
        private int age = 25;
    }
    internal class AccessPrivateFiels
    {
        public void AccessPrivate()
        {
            Person person = new Person();
            Type type = typeof(Person);
            FieldInfo field = type.GetField("age", BindingFlags.NonPublic | BindingFlags.Instance);

            if (field != null)
            {
                field.SetValue(person, 30);
                Console.WriteLine("Updated Age: " + field.GetValue(person));
            }
        }
    }
}