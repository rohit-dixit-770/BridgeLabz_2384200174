using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class ParseJson
    {
        static void Main()
        {
            string jsonData = File.ReadAllText("people.json");
            JArray peopleArray = JArray.Parse(jsonData);

            var filteredPeople = peopleArray.Where(p => (int)p["age"] > 25);
            Console.WriteLine(JArray.FromObject(filteredPeople).ToString());
        }
    }
}
