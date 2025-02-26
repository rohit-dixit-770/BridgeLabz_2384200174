using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class ReadJson
    {
        static void Main()
        {
            string jsonFilePath = "data.json";
            string jsonData = File.ReadAllText(jsonFilePath);
            JArray jsonArray = JArray.Parse(jsonData);

            foreach (var item in jsonArray)
            {
                Console.WriteLine($"Name: {item["name"]}, Email: {item["email"]}");
            }
        }
    }
}
