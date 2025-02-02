using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorVariableModifier
{
    class Student
    {
        public int rollNumber;
        protected string name;
        private double cgpa;

        public Student(int rollNumber, string name, double cgpa)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.cgpa = cgpa;
        }

        public double GetCGPA()
        {
            return this.cgpa;
        }
        public void SetCGPA(double cgpa)
        {
            this.cgpa = cgpa;
        }
    }

    class PostgraduateStudent : Student
    {
        public string researchTopic;

        public PostgraduateStudent(int rollNumber, string name, double cgpa, string researchTopic)
            : base(rollNumber, name, cgpa)
        {
            this.researchTopic = researchTopic;
        }

        public static void Main()
        {
            PostgraduateStudent pgStudent = new PostgraduateStudent(174, "Rohit", 9.5, "Scheduling");
            Console.WriteLine($"Roll number: {pgStudent.rollNumber}");
            Console.WriteLine($"name: {pgStudent.name}");
            Console.WriteLine($"CGPA: {pgStudent.GetCGPA()}");
            Console.WriteLine($"Research topic: {pgStudent.researchTopic}");
        }

    }
}
