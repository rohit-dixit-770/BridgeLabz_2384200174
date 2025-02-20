using System;

class CountingSort
{
    static int[] CountingSortAges(int[] arr, int min, int max)
    {
        int range = max - min + 1;
        int[] count = new int[range];
        int[] output = new int[arr.Length];
        
        for (int i = 0; i < arr.Length; i++)
        {
            count[arr[i] - min]++;
        }
        
        for (int i = 1; i < range; i++)
        {
            count[i] += count[i - 1];
        }
        
        for (int i = arr.Length - 1; i >= 0; i--)
        {
            output[count[arr[i] - min] - 1] = arr[i];
            count[arr[i] - min]--;
        }
        
        return output;
    }
	static void Main()
    {
        int[] studentAges = { 12, 15, 14, 10, 18, 13, 17, 11, 16, 10, 14, 15 };
        
        Console.WriteLine("Original Student Ages: " + string.Join(", ", studentAges));
        
        int[] sortedAges = CountingSortAges(studentAges, 10, 18);
        
        Console.WriteLine("Sorted Student Ages: " + string.Join(", ", sortedAges));
    }
}
