using System;
using System.Collections.Generic;

public class LongestConsecutiveSequence
{
    public static int FindLongestConsecutiveSequence(int[] nums)
    {
        HashSet<int> numSet = new HashSet<int>(nums);
        int longestStreak = 0;

        foreach (int num in nums)
        {
            if (!numSet.Contains(num - 1))
            {
                int currentNum = num;
                int currentStreak = 1;

                while (numSet.Contains(currentNum + 1))
                {
                    currentNum += 1;
                    currentStreak += 1;
                }

                longestStreak = Math.Max(longestStreak, currentStreak);
            }
        }

        return longestStreak;
    }

    public static void Main()
    {
        int[] nums = { 100, 4, 200, 1, 3, 2 };
        int longestStreak = FindLongestConsecutiveSequence(nums);
        Console.WriteLine("Longest Consecutive Sequence: " + longestStreak);
        Console.ReadKey();
    }
}
