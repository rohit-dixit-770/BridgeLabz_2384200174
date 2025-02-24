using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_6_Reflection
{
    class Configuration
    {
        private static string API_KEY = "OriginalKey";

        public static string GetApiKey()
        {
            return API_KEY;
        }
    }


    class Modify
    {
        public void ModifyStatic()
        {
            Type configType = typeof(Configuration);
            FieldInfo field = configType.GetField("API_KEY", BindingFlags.NonPublic | BindingFlags.Static);

            if (field != null)
            {
                field.SetValue(null, "ModifiedKey");
                Console.WriteLine("Modified API_KEY: " + Configuration.GetApiKey());
            }
            else
            {
                Console.WriteLine("Field not found.");
            }
        }
    }
}
