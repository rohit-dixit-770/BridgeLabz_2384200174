using System;

class InsertionSort
{   
    static void InsertionSortEmployeeIDs(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            
            // Move elements of arr[0..i-1], that are greater than key,
            // to one position ahead of their current position
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }
	static void Main()
    {
        int[] employeeIDs = { 103, 101, 107, 105, 102, 106, 104 };
        
        Console.WriteLine("Original Employee IDs: " + string.Join(", ", employeeIDs));
        
        InsertionSortEmployeeIDs(employeeIDs);
        
        Console.WriteLine("Sorted Employee IDs: " + string.Join(", ", employeeIDs));
    }
}
