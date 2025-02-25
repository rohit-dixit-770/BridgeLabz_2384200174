using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class FilterRrecord
    {
        public void FilterStudent()
        {
            try
            {
                string filePath = @"C:\\Users\\anilk\\OneDrive\\Desktop\\csharp\\Bridgelabz_2384200020\\Week 5 assignment 1 DataHandling\\Week 5 Assignment 1\\Student.csv";
                using (StreamReader re = new StreamReader(filePath))
                {
                    string line;
                    Console.WriteLine("The Student details who has above 80 marks: ");
                    while ((line = re.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        int mark = Convert.ToInt32(data[3]);
                        
                        if (mark > 80)
                        {
                            Console.WriteLine(data[0] + ", " + data[1] + ", " + data[2] + ", " + data[3]);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
