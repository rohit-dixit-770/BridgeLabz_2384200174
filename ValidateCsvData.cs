using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Week_5_Assignment_1
{
    
    internal class ValidateCsvData
    {
        
        [EmailCheckAttribute]
        public string email;

        [MobileAttribute]
        public string mobileNumber;
        public void DataValidate()
        {
            try
            {
                EmailCheckAttribute emailCheckAttribute = new EmailCheckAttribute();
                MobileAttribute mobileAttribute = new MobileAttribute();
                string filePath = @"C:\Users\anilk\OneDrive\Desktop\csharp\Bridgelabz_2384200020\Week 5 assignment 1 DataHandling\Week 5 Assignment 1\DataProcessing.csv";
                using StreamReader reader = new StreamReader(filePath);
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] data = line.Split(',');
                        if (!emailCheckAttribute.IsValidEmail(data[0]) || (!mobileAttribute.IsValidMobile(data[1])))
                        {

                            Console.WriteLine("invalid data.");
                            Console.WriteLine(line);

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

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)] 
    public class EmailCheckAttribute : Attribute
    {
        public bool IsValidEmail(string email)
        {
            string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            return Regex.IsMatch(email, pattern);
        }
    }

    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    public class MobileAttribute : Attribute
    {
        public bool IsValidMobile(string mobile)
        {
            string pattern = @"^(0|91)?[6-9][0-9]{9}$";
            return Regex.IsMatch(mobile, pattern);
        }
    }

}
