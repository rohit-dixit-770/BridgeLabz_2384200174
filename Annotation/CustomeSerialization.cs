using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;


namespace Week_4_Assignment_6_Annotion
{
    

    [AttributeUsage(AttributeTargets.Field | AttributeTargets.Property)]
    public class JsonFieldAttribute : Attribute
    {
        public string Name { get; }
        public JsonFieldAttribute(string name) => Name = name;
    }

    public class Usercw
    {
        [JsonField( "user_name")]
        public string Name { get; set; }

        [JsonField("user_age")]
        public int Age { get; set; }
    }

    public static class JsonSerializerHelper
    {
        public static string SerializeToJson(object obj)
        {
            var jsonDict = new Dictionary<string, object>();
            var type = obj.GetType();

            foreach (var prop in type.GetProperties())
            {
                var attr = prop.GetCustomAttribute<JsonFieldAttribute>();
                if (attr != null)
                {
                    jsonDict[attr.Name] = prop.GetValue(obj);
                }
            }

            return JsonConvert.SerializeObject(jsonDict, Formatting.Indented);
        }
    }
}