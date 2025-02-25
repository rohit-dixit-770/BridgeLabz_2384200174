using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class CountRowInCSVFIle
    {
        public void CountRow()
        {
            try
            {
                string filePath = @"C:\\Users\\anilk\\OneDrive\\Desktop\\csharp\\Bridgelabz_2384200020\\Week 5 assignment 1 DataHandling\\Week 5 Assignment 1\\Student.csv";
                using (StreamReader sr = new StreamReader(filePath))
                {
                    int count = 0;
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        count++;
                    }
                    Console.WriteLine("the number of line is : " + (count - 1));

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
