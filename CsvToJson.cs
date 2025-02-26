using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class CsvToJson
    {
        static void Main()
        {
            var lines = File.ReadAllLines("info.csv");
            var headers = lines[0].Split(',');
            var jsonArray = new JArray(
                lines.Skip(1).Select(line => new JObject(headers.Zip(line.Split(','), (h, v) => new JProperty(h, v))))
            );
            Console.WriteLine(jsonArray.ToString());
        }
    }
}
