using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_Assignment_1
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }
    internal class CSVDataIntoJavaObject
    {
        public void ConvertIntoJavaObject()
        {
            try

            {
                
                string filePath = @"C:\Users\anilk\OneDrive\Desktop\csharp\Bridgelabz_2384200020\Week 5 assignment 1 DataHandling\Week 5 Assignment 1\DataProcessing.csv";  //path of student data file
                List<Student> students = new List<Student>();

                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        int id = int.Parse(data[0]);
                        string name = data[1];
                        int age = int.Parse(data[2]);
                        students.Add(new Student { Id = id, Name = name, Age = age });
                        
                    }
                }
                foreach (Student student in students)
                {
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.Id);
                }
                

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }
    }
}
