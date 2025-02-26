using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class MergeJson
    {
        static void Main()
        {
            JObject json1 = JObject.Parse("{ \"name\": \"Rohit\", \"age\": 25 }");
            JObject json2 = JObject.Parse("{ \"email\": \"Rohit@gmail.com\", \"city\": \"MTJ\" }");

            json1.Merge(json2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            Console.WriteLine(json1.ToString());
        }
    }
}
