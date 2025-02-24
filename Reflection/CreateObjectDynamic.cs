using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Week_4_Assignment_6_Reflection
{
    class Student
    {
        public Student()
        {
            Console.WriteLine("Student object created!");
        }
    }
    internal class CreateObjectDynamic
    {
        public void ObjectCreation()
        {
            Type type = typeof(Student);
            object obj = Activator.CreateInstance(type);
        }
    }
}
