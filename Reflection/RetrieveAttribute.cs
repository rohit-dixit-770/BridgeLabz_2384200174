using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Week_4_Assignment_6_Reflection
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false)]
    public class AuthorAttribute : Attribute
    {
        public string Name { get; }

        public AuthorAttribute(string name)
        {
            Name = name;
        }
    }
    [Author("John Doe")]
    public class SampleClass
    {
    }
    class GetInput
    {
        public void ChangeAuthor()
        {
            Type type = typeof(SampleClass);
            object[] attributes = type.GetCustomAttributes(typeof(AuthorAttribute), false);

            if (attributes.Length > 0)
            {
                AuthorAttribute authorAttribute = (AuthorAttribute)attributes[0];
                Console.WriteLine($"Author: {authorAttribute.Name}");
            }
            else
            {
                Console.WriteLine("No Author attribute found.");
            }
        }
    }

}
