using System;
using System.Collections.Generic;

public class PairWithGivenSum
{
    public static bool FindPairWithGivenSum(int[] nums, int target)
    {
        HashSet<int> seenNumbers = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int difference = target - nums[i];

            if (seenNumbers.Contains(difference))
            {
                Console.WriteLine($"Pair found: ({nums[i]}, {difference})");
                return true;
            }

            seenNumbers.Add(nums[i]);
        }

        Console.WriteLine("No pair found");
        return false;
    }

    public static void Main()
    {
        int[] nums = { 10, 15, 3, 7 };
        int target = 17;
        FindPairWithGivenSum(nums, target);
        Console.ReadKey();
    }
}
