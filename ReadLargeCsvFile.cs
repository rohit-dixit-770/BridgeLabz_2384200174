using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class ReadLargeCsvFile
    {
        public void LargeRead()
        {
            string filePath = "largefile.csv"; // Update with your file path
            int chunkSize = 100;
            int totalProcessed = 0;

            using (StreamReader reader = new StreamReader(filePath))
            {
                List<string> lines = new List<string>();
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    lines.Add(line);

                    if (lines.Count == chunkSize)
                    {
                        ProcessLines(lines);
                        totalProcessed += lines.Count;
                        Console.WriteLine($"Processed {totalProcessed} records...");
                        lines.Clear();
                    }
                }

                // Process any remaining lines
                if (lines.Count > 0)
                {
                    ProcessLines(lines);
                    totalProcessed += lines.Count;
                    Console.WriteLine($"Processed {totalProcessed} records...");
                }
            }
        }

        public void ProcessLines(List<string> lines)
        {
            // Process each line (Modify as needed)
            foreach (var line in lines)
            {
                // Example: just print the first 10 characters
                Console.WriteLine(line.Length > 10 ? line.Substring(0, 10) : line);
            }
        }
    }
    
}
