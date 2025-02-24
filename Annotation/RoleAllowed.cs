using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Annotion
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
    public class RoleAllowedAttribute : Attribute
    {
        public string Role { get; }

        public RoleAllowedAttribute(string role)
        {
            Role = role;
        }
    }

    public class Userc
    {
        public string Role { get; set; }

        public Userc(string role)
        {
            Role = role;
        }
    }

    public class SecureService
    {
        private Userc _currentUser;

        public SecureService(Userc user)
        {
            _currentUser = user;
        }

        public void Invoke(string methodName)
        {
            MethodInfo method = typeof(SecureService).GetMethod(methodName);
            var attribute = method.GetCustomAttribute<RoleAllowedAttribute>();

            if (attribute != null && attribute.Role != _currentUser.Role)
            {
                Console.WriteLine("Access Denied!");
                return;
            }

            method.Invoke(this, null);
        }

        [RoleAllowed("ADMIN")]
        public void AdminTask()
        {
            Console.WriteLine("Admin task executed!");
        }
    }
}
