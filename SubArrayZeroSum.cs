using System;
using System.Collections.Generic;

public class ZeroSumSubarrays
{
    public static List<Tuple<int, int>> FindZeroSumSubarrays(int[] nums)
    {
        List<Tuple<int, int>> result = new List<Tuple<int, int>>();
        Dictionary<int, List<int>> sumMap = new Dictionary<int, List<int>>();
        int cumSum = 0;

        sumMap[cumSum] = new List<int> { -1 };  

        for (int i = 0; i < nums.Length; i++)
        {
            cumSum += nums[i];

            if (sumMap.ContainsKey(cumSum))
            {
                foreach (int index in sumMap[cumSum])
                {
                    result.Add(new Tuple<int, int>(index + 1, i));
                }
            }

            if (!sumMap.ContainsKey(cumSum))
            {
                sumMap[cumSum] = new List<int>();
            }

            sumMap[cumSum].Add(i);
        }

        return result;
    }

    public static void Main()
    {
        int[] nums = { 1, 2, -3, 4, -4, 2, -2, 3, -3 };
        List<Tuple<int, int>> zeroSumSubarrays = FindZeroSumSubarrays(nums);

        Console.WriteLine("Zero Sum Subarrays:");
        foreach (var subarray in zeroSumSubarrays)
        {
            Console.WriteLine("Start: {0}, End: {1}" , subarray.Item1 , subarray.Item2);
        }
    }
}
