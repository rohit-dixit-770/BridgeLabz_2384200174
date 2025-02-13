using System;
using System.Collections.Generic;

public class QueueUsingStacks<T>
{
    private Stack<T> stack1;
    private Stack<T> stack2;

    public QueueUsingStacks()
    {
        stack1 = new Stack<T>();
        stack2 = new Stack<T>();
    }

    // Enqueue operation
    public void Enqueue(T item)
    {
        stack1.Push(item);
    }

    // Dequeue operation
    public T Dequeue()
    {
        if (stack2.Count == 0)
        {
            // Transfer elements from stack1 to stack2
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return stack2.Pop();
    }

    // Peek operation to get the front element of the queue
    public T Peek()
    {
        if (stack2.Count == 0)
        {
            // Transfer elements from stack1 to stack2
            while (stack1.Count > 0)
            {
                stack2.Push(stack1.Pop());
            }
        }

        if (stack2.Count == 0)
        {
            throw new InvalidOperationException("Queue is empty");
        }

        return stack2.Peek();
    }

    // Check if the queue is empty
    public bool IsEmpty()
    {
        return stack1.Count == 0 && stack2.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        QueueUsingStacks<int> queue = new QueueUsingStacks<int>();

        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);

        Console.WriteLine("Dequeue: " + queue.Dequeue()); 
        Console.WriteLine("Peek: " + queue.Peek());       
        Console.WriteLine("Dequeue: " + queue.Dequeue()); 
        Console.WriteLine("IsEmpty: " + queue.IsEmpty()); 
        Console.ReadKey();
    }
}
