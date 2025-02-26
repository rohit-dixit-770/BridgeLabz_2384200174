using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System.Xml.Linq;

namespace JSONassignment
{
    internal class JsonToXml
    {
        static void Main()
        {
            string json = File.ReadAllText("data.json");
            JObject jsonObj = JObject.Parse(json);
            XDocument xml = JsonConvert.DeserializeXNode(jsonObj.ToString(), "Root");
            Console.WriteLine(xml.ToString());
        }
    }
}
