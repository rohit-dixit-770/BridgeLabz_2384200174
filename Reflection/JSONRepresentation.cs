using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    public class JsonConverter
    {
        public static string ToJson(object obj)
        {
            if (obj == null) return "null";

            Type type = obj.GetType();
            StringBuilder jsonBuilder = new StringBuilder();
            jsonBuilder.Append("{");

            FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);
            PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            bool first = true;

            foreach (var field in fields)
            {
                if (!first) jsonBuilder.Append(", ");
                jsonBuilder.AppendFormat("\"{0}\": \"{1}\"", field.Name, field.GetValue(obj));
                first = false;
            }

            foreach (var prop in properties)
            {
                if (!first) jsonBuilder.Append(", ");
                jsonBuilder.AppendFormat("\"{0}\": \"{1}\"", prop.Name, prop.GetValue(obj));
                first = false;
            }

            jsonBuilder.Append("}");
            return jsonBuilder.ToString();
        }
    }
    public class Personcw
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    //Act like main class 
    class Representation
    {
        public void Represent()
        {
            Personcw person = new Personcw { Name = "John Doe", Age = 30 };
            string json = JsonConverter.ToJson(person);
            Console.WriteLine(json);
        }
    }
}
