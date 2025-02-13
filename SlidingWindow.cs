using System;
using System.Collections.Generic;


public class Deque<T> : LinkedList<T>
{
    public void AddLast(T item)
    {
        base.AddLast(item);
    }

    public void RemoveFirst()
    {
        base.RemoveFirst();
    }

    public void RemoveLast()
    {
        base.RemoveLast();
    }

    public T GetFirst()
    {
        return this.First.Value;
    }

    public T GetLast()
    {
        return this.Last.Value;
    }
}
public class SlidingWindowMaximum
{
    public static int[] FindMaxInSlidingWindow(int[] nums, int k)
    {
        if (nums == null || nums.Length == 0 || k <= 0)
        {
            return new int[0];
        }

        int n = nums.Length;
        int[] result = new int[n - k + 1];
        Deque<int> deque = new Deque<int>();

        for (int i = 0; i < n; i++)
        {
            // Remove elements from the back of the deque while the current element is greater
            while (deque.Count > 0 && nums[i] >= nums[deque.GetLast()])
            {
                deque.RemoveLast();
            }

            // Add the current element's index to the back of the deque
            deque.AddLast(i);

            // Remove the front element if its index is outside the current window
            if (deque.GetFirst() < i - k + 1)
            {
                deque.RemoveFirst();
            }

            // The front element of the deque is the max in the current window
            if (i >= k - 1)
            {
                result[i - k + 1] = nums[deque.GetFirst()];
            }
        }

        return result;
    }

    public static void Main()
    {
        int[] nums = { 1, 3, -1, -3, 5, 3, 6, 7 };
        int k = 3;
        int[] maxInWindows = FindMaxInSlidingWindow(nums, k);

        Console.WriteLine("Sliding Window Maximum:");
        foreach (int max in maxInWindows)
        {
            Console.Write(max + " ");
            Console.ReadKey();
        }
    }
}

