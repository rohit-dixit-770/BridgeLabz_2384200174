using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentRecordManagement
{
    public class Node
    {
        public int rollNumber;
        public string name;
        public int age;
        public char grade;
        public Node next;

        public Node(int rollNumber, string name, int age, char grade)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

         public Node(int rollNumber, string name, int age, char grade ,Node next)
        {
            this.rollNumber = rollNumber;
            this.name = name;
            this.age = age;
            this.grade = grade;
        }
        public override string ToString()
        {
            return $"Roll Number: {rollNumber}, Name: {name}, Age: {age}, Grade: {grade}";

        }
    }
}
