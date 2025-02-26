using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONassignment
{
    internal class ValidateEmail
    {
        static void Main()
        {
            string schemaJson = File.ReadAllText("schema.json");
            JSchema schema = JSchema.Parse(schemaJson);
            JObject user = JObject.Parse(File.ReadAllText("user.json"));

            bool isValid = user.IsValid(schema, out IList<string> errors);
            Console.WriteLine(isValid ? "Valid Email" : "Invalid Email");
        }
    }
}
