using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class MergeTwoCSV
    {
        public void TwoCsvMerge()
        {
            string file1 = "students1.csv";  //path of first csv file
            string file2 = "students2.csv";   //path of second csv file
            string outputFile = "merged_students.csv";

            var students1 = new Dictionary<string, (string Name, string Age)>();
            var students2 = new Dictionary<string, (string Marks, string Grade)>();

            using (StreamReader reader = new StreamReader(file1))
            {
                reader.ReadLine(); // Skip header
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    students1[parts[0]] = (parts[1], parts[2]);
                }
            }

            using (StreamReader reader = new StreamReader(file2))
            {
                reader.ReadLine(); // Skip header
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    students2[parts[0]] = (parts[1], parts[2]);
                }
            }

            using (StreamWriter writer = new StreamWriter(outputFile))
            {
                writer.WriteLine("ID,Name,Age,Marks,Grade");

                foreach (var id in students1.Keys)
                {
                    if (students2.ContainsKey(id))
                    {
                        var student1 = students1[id];
                        var student2 = students2[id];
                        writer.WriteLine($"{id},{student1.Name},{student1.Age},{student2.Marks},{student2.Grade}");
                    }
                }
            }

            Console.WriteLine("Merged file created successfully!");

        }
    }
}
