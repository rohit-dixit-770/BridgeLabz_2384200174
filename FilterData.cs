using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace JSONassignment
{
    internal class FilterData
    {
        static void Main()
        {
            string json = File.ReadAllText("people.json");
            JArray jsonArray = JArray.Parse(json);

            var filteredUsers = jsonArray.Where(u => (int)u["age"] > 25);
            Console.WriteLine(JArray.FromObject(filteredUsers).ToString());
        }
    }
}
