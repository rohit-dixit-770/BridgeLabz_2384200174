using System;

class SelectionSort
{
    static void SelectionSortExamScores(int[] arr)
    {
        int n = arr.Length;
        
        for (int i = 0; i < n - 1; i++)
        {
            int minIndex = i;
            
            for (int j = i + 1; j < n; j++)
            {
                if (arr[j] < arr[minIndex])
                {
                    minIndex = j;
                }
            }
            
            Swap(ref arr[minIndex], ref arr[i]);
        }
    }
    
    static void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }
	static void Main()
    {
        int[] examScores = { 78, 92, 85, 67, 88, 76, 95, 89 };
        
        Console.WriteLine("Original Exam Scores: " + string.Join(", ", examScores));
        
        SelectionSortExamScores(examScores);
        
        Console.WriteLine("Sorted Exam Scores: " + string.Join(", ", examScores));
    }
}
