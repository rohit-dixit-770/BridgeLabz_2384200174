using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class MaxLengthAttribute : Attribute
    {
        public int Length { get; }

        public MaxLengthAttribute(int length)
        {
            Length = length;
        }
    }

    public class User
    {
        [MaxLength(10)]
        public string Username { get; }

        public User(string username)
        {
            ValidateMaxLength(username);
            Username = username;
        }

        private void ValidateMaxLength(string value)
        {
            PropertyInfo prop = typeof(User).GetProperty(nameof(Username));
            var attribute = (MaxLengthAttribute)Attribute.GetCustomAttribute(prop, typeof(MaxLengthAttribute));

            if (attribute != null && value.Length > attribute.Length)
            {
                throw new ArgumentException($"Username cannot exceed {attribute.Length} characters.");
            }
        }
    }

}
