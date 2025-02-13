using System;
using System.Collections.Generic;
public class StockSpan
{
    public static int[] CalculateSpan(int[] prices)
    {
        int n = prices.Length;
        int[] span = new int[n];
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            // Pop elements from the stack 
            while (stack.Count > 0 && prices[i] >= prices[stack.Peek()])
            {
                stack.Pop();
            }

            // Calculate span
            span[i] = (stack.Count == 0) ? (i + 1) : (i - stack.Peek());

            // Push current index to the stack
            stack.Push(i);
        }

        return span;
    }

    public static void Main()
    {
        int[] prices = { 100, 80, 60, 70, 60, 75, 85 };
        int[] span = CalculateSpan(prices);

        Console.WriteLine("Stock Span:");
        for (int i = 0; i < span.Length; i++)
        {
            Console.Write(span[i] + " ");
            Console.ReadKey();
        }
    }
}
