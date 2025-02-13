using System;
using System.Collections.Generic;

public class TwoSum
{
    public static int[] FindTwoSum(int[] nums, int target)
    {
        Dictionary<int, int> numMap = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];
 
            if (numMap.ContainsKey(difference))
            {
                return new int[] { numMap[difference], i };
            }

            if (!numMap.ContainsKey(nums[i]))
            {
                numMap[nums[i]] = i;
            }
        }
        return new int[] {};
    }

    public static void Main()
    {
        int[] nums = { 2, 7, 11, 15 };
        int target = 9;
        int[] result = FindTwoSum(nums, target);
        Console.WriteLine("Indices: {0}, {1}", result[0] , result[1]);
    }
}
