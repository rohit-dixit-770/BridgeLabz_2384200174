using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class DetectDuplicate
    {
        public void Duplicate()
        {
            string filePath = "data.csv";
            if (!File.Exists(filePath)) return;

            var idCounts = new Dictionary<string, List<string>>();

            using (var reader = new StreamReader(filePath))
            {
                reader.ReadLine(); // Skip header
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var id = line.Split(',')[0];

                    if (!idCounts.ContainsKey(id))
                        idCounts[id] = new List<string>();

                    idCounts[id].Add(line);
                }
            }

            foreach (var duplicate in idCounts.Where(kv => kv.Value.Count > 1).SelectMany(kv => kv.Value))
            {
                Console.WriteLine(duplicate);
            }
        }
    }
}
