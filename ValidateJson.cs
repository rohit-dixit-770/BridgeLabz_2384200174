using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;

namespace JSONassignment
{
    class ValidateJson
    {
        static void Main()
        {
            string schemaJson = File.ReadAllText("schema.json");
            JSchema schema = JSchema.Parse(schemaJson);

            JObject userJson = JObject.Parse("{ \"name\": \"Rohit\", \"email\": \"Rohit@gmail.com\" }");

            bool isValid = userJson.IsValid(schema, out IList<string> validationErrors);
            Console.WriteLine(isValid ? "Valid JSON" : "Invalid JSON");
        }
    }
}
