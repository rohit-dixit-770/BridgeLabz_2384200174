using System;

class BubbleSort
{
    static void BubbleSortMarks(int[] arr)
    {
        int n = arr.Length;
        bool swapped;
        
        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;
            
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap adjacent elements if they are in the wrong order
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                    
                    swapped = true;
                }
            }
            
            // If no swaps occurred in the inner loop, the array is already sorted
            if (!swapped)
                break;
        }
    }
	static void Main()
    {
        int[] marks = { 85, 78, 92, 67, 88, 76, 95, 89 };
        
        Console.WriteLine("Original Marks: " + string.Join(", ", marks));
        
        BubbleSortMarks(marks);
        
        Console.WriteLine("Sorted Marks: " + string.Join(", ", marks));
    }
}
