using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class MergeTwoJsonFile
    {
        static void Main()
        {
            JObject json1 = JObject.Parse(File.ReadAllText("user.json"));
            JObject json2 = JObject.Parse(File.ReadAllText("userData.json"));

            json1.Merge(json2, new JsonMergeSettings { MergeArrayHandling = MergeArrayHandling.Union });

            Console.WriteLine(json1.ToString());
        }
    }
}
