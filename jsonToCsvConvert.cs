using CsvHelper.Configuration;
using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;
namespace Week_5_Assignment_1
{
    internal class JsonToCsvConvert
    {
        public void ConvertJsonToCsv()
        {
            string jsonFilePath = "students.json";
            string csvFilePath = "students.csv";

            // Convert JSON to CSV
            ConvertJsonToCsv(jsonFilePath, csvFilePath);
            Console.WriteLine("JSON converted to CSV successfully.");

            // Convert CSV back to JSON
            string newJsonFilePath = "students_converted.json";
            ConvertCsvToJson(csvFilePath, newJsonFilePath);
            Console.WriteLine("CSV converted back to JSON successfully.");
        }
        static void ConvertJsonToCsv(string jsonFilePath, string csvFilePath)
        {
            var jsonData = File.ReadAllText(jsonFilePath);
            var students = JsonConvert.DeserializeObject<List<Studentc>>(jsonData);

            using (var writer = new StreamWriter(csvFilePath))
            using (var csv = new CsvWriter(writer, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                csv.WriteRecords(students);
            }
        }

        static void ConvertCsvToJson(string csvFilePath, string jsonFilePath)
        {
            using (var reader = new StreamReader(csvFilePath))
            using (var csv = new CsvReader(reader, new CsvConfiguration(CultureInfo.InvariantCulture)))
            {
                var students = csv.GetRecords<Studentc>();
                var jsonData = JsonConvert.SerializeObject(students, Formatting.Indented);
                File.WriteAllText(jsonFilePath, jsonData);
            }
        }
    }
    public class Studentc
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Grade { get; set; }
    }
}
