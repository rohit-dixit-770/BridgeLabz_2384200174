using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UndoRedoFunctionality
{
    public class TextStateLinkedList
    {
        private TextStateNode head; 
        private TextStateNode tail; 
        private TextStateNode current; 
        private int maxSize; 
        private int size; 

        public TextStateLinkedList(int maxSize)
        {
            head = null;
            tail = null;
            current = null;
            this.maxSize = maxSize;
            size = 0;
        }

        // Add a new text state at the end of the list
        public void AddTextState(string content)
        {
            TextStateNode newNode = new TextStateNode(content);
            if (tail == null)
            {
                head = newNode;
                tail = newNode;
                current = newNode;
            }
            else
            {
                tail.Next = newNode;
                newNode.Prev = tail;
                tail = newNode;
                current = newNode;
            }

            size++;
            if (size > maxSize)
            {
                RemoveFirst();
            }
        }

        // Remove the first text state node (oldest state)
        private void RemoveFirst()
        {
            if (head == null)
            {
                return;
            }

            head = head.Next;
            if (head != null)
            {
                head.Prev = null;
            }

            size--;
        }

        // Implement the undo functionality (revert to the previous state)
        public void Undo()
        {
            if (current == null || current.Prev == null)
            {
                Console.WriteLine("No undo available.");
                return;
            }

            current = current.Prev;
        }

        // Implement the redo functionality (revert back to the next state after undo)
        public void Redo()
        {
            if (current == null || current.Next == null)
            {
                Console.WriteLine("No redo available.");
                return;
            }

            current = current.Next;
        }

        // Display the current state of the text
        public void DisplayCurrentState()
        {
            if (current == null)
            {
                Console.WriteLine("No current state available.");
                return;
            }

            Console.WriteLine("Current State: " + current.Content);
        }
    }

}
