using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    class ReadPrintkv
    {
        static void Main()
        {
            string jsonText = File.ReadAllText("data.json");
            JObject jsonObj = JObject.Parse(jsonText);

            foreach (var item in jsonObj)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
