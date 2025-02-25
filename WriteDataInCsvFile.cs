using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class WriteDataInCsvFile
    {
        public void WriteFile()
        {
            try
            {
                Console.WriteLine("Enter or paste your file path where you want to write: ");
                string filePath = Console.ReadLine();

                using (StreamWriter write = new StreamWriter(filePath))
                {
                    write.WriteLine("Id,Name,Department,Salary");
                    Console.WriteLine("Enter the id,name,department,salary");
                    for (int i = 0; i < 5; i++)
                    {
                        string data = Console.ReadLine();
                        string[] array = data.Split(',');
                        write.WriteLine("{0},{1},{2},{3}", array[0], array[1], array[2], array[3]);
                    }
                }
                
                Console.WriteLine("data added successfully.");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}