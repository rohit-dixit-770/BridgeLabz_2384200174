using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Course
    {
        public string courseName;
        public int duration;
        public double fee;
        public static string instituteName = "GL University";

        public Course(string courseName, int duration, double fee)
        {
            this.courseName = courseName;
            this.duration = duration;
            this.fee = fee;
        }

        public void DisplayCourseDetails()
        {
            Console.WriteLine($"Course: {this.courseName}, Duration: {this.duration} weeks, Fee: {this.fee}, Institute: {Course.instituteName}");
        }

        public static void UpdateInstituteName(string newName)
        {
            Course.instituteName = newName;
        }

        public static void Main()
        {
            Course course = new Course("MCA", 3, 300000);

            course.DisplayCourseDetails();
            Course.UpdateInstituteName("GLA University");
            Console.WriteLine($" Institute Name is {Course.instituteName}");

        }
    }
}
