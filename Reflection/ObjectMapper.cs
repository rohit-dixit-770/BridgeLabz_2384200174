using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    public class ObjectMapper
    {
        public static T ToObject<T>(Dictionary<string, object> properties) where T : new()
        {
            T obj = new T();
            Type type = typeof(T);

            foreach (var prop in properties)
            {
                PropertyInfo propertyInfo = type.GetProperty(prop.Key, BindingFlags.Public | BindingFlags.Instance);
                if (propertyInfo != null && propertyInfo.CanWrite)
                {
                    object value = Convert.ChangeType(prop.Value, propertyInfo.PropertyType);
                    propertyInfo.SetValue(obj, value);
                }
            }
            return obj;
        }
    }
    public class Personc
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //act like main class
    class MapObject
    {
        public void MapperObject()
        {
            var properties = new Dictionary<string, object>
        {
            {"Name", "John Doe"},
            {"Age", 30}
        };

            Personc person = ObjectMapper.ToObject<Personc>(properties);
            Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        }
    }
}
