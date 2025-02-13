using System;
using System.Collections.Generic;

public class SortStack
{
    public static void Sort(Stack<int> stack)
    {
        if (stack.Count > 0)
        {
            // Pop the top element
            int temp = stack.Pop();

            // Sort the remaining stack
            Sort(stack);

            // Insert the popped element back in sorted order
            InsertSorted(stack, temp);
        }
    }

    private static void InsertSorted(Stack<int> stack, int element)
    {
        // If stack is empty or element is greater than the top element
        if (stack.Count == 0 || element > stack.Peek())
        {
            stack.Push(element);
        }
        else
        {
            // Pop the top element
            int temp = stack.Pop();

            // Insert element into the sorted stack
            InsertSorted(stack, element);

            // Push the popped element back
            stack.Push(temp);
        }
    }

    public static void PrintStack(Stack<int> stack)
    {
        foreach (int item in stack)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Stack<int> stack = new Stack<int>();

        stack.Push(30);
        stack.Push(10);
        stack.Push(50);
        stack.Push(20);
        stack.Push(40);

        Console.WriteLine("Original Stack:");
        SortStack.PrintStack(stack);

        SortStack.Sort(stack);

        Console.WriteLine("Sorted Stack:");
        SortStack.PrintStack(stack);
        Console.ReadKey();
    }
}
