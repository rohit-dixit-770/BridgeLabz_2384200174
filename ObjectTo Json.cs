using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{

    class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }
    internal class ObjectToJson
    {
        static void Main()
        {
            Car car = new Car
            {
                Make = "Toyota",
                Model = "Corolla",
                Year = 2022
            };

            // Convert to JSON
            string json = JsonConvert.SerializeObject(car, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
