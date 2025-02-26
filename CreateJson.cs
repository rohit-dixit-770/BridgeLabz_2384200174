using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }
    class CreateJson
    {
        static void Main()
        {
            Student student = new Student
            {
                Name = "Rohit",
                Age = 20,
                Subjects = new List<string> { "Math", "Science", "History" }
            };

            // Convert to JSON
            string json = JsonConvert.SerializeObject(student, Formatting.Indented);
            Console.WriteLine(json);
        }
    }
}
