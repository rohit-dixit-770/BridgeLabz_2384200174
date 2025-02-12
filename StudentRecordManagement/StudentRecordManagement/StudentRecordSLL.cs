using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecordManagement
{
    public class StudentRecordSLL
    {
        private Node head;
        public StudentRecordSLL()
        {
            this.head = null;
        }

        // Add student at the Beginning

        public void AddAtBeginning(int rollNumber, string name, int age, char grade) 
        {
            Node newStudent = new Node(rollNumber, name, age, grade);
            newStudent.next = head;
            head = newStudent;
        }

        // Add student at the End
        public void AddAtEnd(int rollNumber, string name, int age, char grade)
        {
            Node newStudent = new Node(rollNumber, name, age, grade);

            if (head == null)
            {
                head = newStudent;
                return;
            }

            Node currentNode = head;
            while (currentNode.next != null) 
            {
                currentNode = currentNode.next;
            }

            currentNode.next = newStudent; 
        }


        // Add student at specific position

        public void AddAtPosition(int rollNumber, string name, int age, char grade, int position) 
        {
            if (position == 0) 
            {
                AddAtBeginning(rollNumber, name, age, grade);
            }

            Node newStudent = new Node(rollNumber, name, age, grade);
            Node currentNode = head;
            int i = 0;
            while (i < position)
            {
                currentNode = currentNode.next;
                i++;
            }

            newStudent.next = currentNode.next;
            currentNode.next = newStudent;
        }

        // Delete a student record by Roll Number

        public void DeleteUsingRollNumber(int rollNumber) 
        {
            if (head == null) 
            {
                Console.WriteLine("Empty List");
                return;
            }

            if (head.rollNumber == rollNumber)
            {
                head = head.next;
                return;
            }
            Node currentNode = head;
            while (currentNode.next != null && currentNode.next.rollNumber != rollNumber) 
            {
                currentNode = currentNode.next;
            }

            if (currentNode.next == null) 
            {
                Console.WriteLine("Student roll number not found");
                return;
            }

            currentNode.next = currentNode.next.next;
        }

        // Search for a student record by Roll Number
        public Node SearchRollNumber(int rollNumber) 
        {
            Node currentNode = head;
            while (currentNode != null) 
            {
                if (currentNode.rollNumber == rollNumber) {
                    return currentNode;
                }
                currentNode = currentNode.next;
            }
            return null;
        }

        // Display all student records.
        public void DisplayAllRecords() 
        {
            Node currentNode = head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.ToString());
                currentNode = currentNode.next;
            }
        }

        // Update a student's grade based on their Roll Number
        public void UpdateGrade(int rollNumber, char newGrade)
        {
            Node student = SearchRollNumber(rollNumber);
            if (student != null)
            {
                student.grade = newGrade;
            }
            else
            {
                Console.WriteLine("Student with given roll number not found");
            }
        }


    }
}
