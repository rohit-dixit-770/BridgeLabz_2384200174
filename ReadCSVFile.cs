using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvHelper;
using System.IO;

namespace Week_5_Assignment_1
{
    internal class ReadCSVFile
    {
        public void ReadFile() 
        {
            string filePath = @"C:\\Users\\anilk\\OneDrive\\Desktop\\csharp\\Bridgelabz_2384200020\\Week 5 assignment 1 DataHandling\\Week 5 Assignment 1\\Student.csv";
            try
            {
                using(StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] column = line.Split(',');
                        Console.WriteLine("Student Id: " + column[0] + " name: " + column[1] + " age: " + column[2] + " mark: " + column[3]);
                    }
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
