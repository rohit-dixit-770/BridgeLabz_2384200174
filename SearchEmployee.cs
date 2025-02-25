using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    internal class SearchEmployee
    {
        public void EmployeeSearch()
        {
            try
            {
                string filePath = @"C:\\Users\\anilk\\OneDrive\\Desktop\\csharp\\Bridgelabz_2384200020\\Week 5 assignment 1 DataHandling\\Week 5 Assignment 1\\Employee.csv";
                Console.WriteLine("Enter the name you want to search: ");
                string searchName = Console.ReadLine();
                using (StreamReader readerr = new StreamReader(filePath))
                {
                    string line;

                    while ((line = readerr.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        string name = data[1];
                        if (name == searchName)
                        {
                            Console.WriteLine("The employee id " + data[0] + " name: " + data[1] + " department: " + data[2] + " salary: " + data[3]);
                            Console.WriteLine("Employee found.");
                        }

                    }
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
