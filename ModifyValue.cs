using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class ModifyValue
    {
        public void ValueModify()
        {
            try
            {
                string filePath = @"C:\Users\anilk\OneDrive\Desktop\csharp\Bridgelabz_2384200020\Week 5 assignment 1 DataHandling\Week 5 Assignment 1\Employee.csv";
                string updateFile = @"C:\Users\anilk\OneDrive\Desktop\csharp\Bridgelabz_2384200020\Week 5 assignment 1 DataHandling\Week 5 Assignment 1\updateEmployeeSalary.csv";
                using StreamWriter writer = new StreamWriter(updateFile);
                using (StreamReader read = new StreamReader(filePath))
                {
                    string line;
                    while (true)
                    {
                        line = read.ReadLine();
                        if (line == null)
                        {
                            break;
                        }
                        else
                        {
                            string[] data = line.Split(',');
                            if (data[2] == "IT" || data[2] == "It")
                            {
                                double salary = Convert.ToDouble(data[3]);
                                salary += salary * 0.1;
                                data[3] = Convert.ToString(salary);
                                string updateLine=string.Join(",",data);
                                writer.WriteLine(updateLine);
                            }
                        }
                    }
                }
                Console.WriteLine("Updated Data added.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

    }
}
