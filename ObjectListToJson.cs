using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JSONassignment
{
    class Student1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public List<string> Subjects { get; set; }
    }
    class ObjectListToJson
    {
        static void Main()
        {
            List<Student1> students = new List<Student1>
            {
                new Student1 { Name = "Rohit", Age = 22, Subjects = new List<string> { "Physics", "Chemistry" } },
                new Student1 { Name = "Rahul", Age = 24, Subjects = new List<string> { "Biology", "Math" } }
            };

            string studentsJson = JsonConvert.SerializeObject(students, Formatting.Indented);
            Console.WriteLine(studentsJson);
        }


    }
}
