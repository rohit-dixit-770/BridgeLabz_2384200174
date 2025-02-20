using System;

class HeapSort
{
    static void HeapSortSalaries(double[] arr)
    {
        int n = arr.Length;
        
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(arr, n, i);
        }
        
        for (int i = n - 1; i > 0; i--)
        {
            Swap(ref arr[0], ref arr[i]);
            Heapify(arr, i, 0);
        }
    }
    
    static void Heapify(double[] arr, int n, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;
        
        if (left < n && arr[left] > arr[largest])
        {
            largest = left;
        }
        
        if (right < n && arr[right] > arr[largest])
        {
            largest = right;
        }
        
        if (largest != i)
        {
            Swap(ref arr[i], ref arr[largest]);
            Heapify(arr, n, largest);
        }
    }
    
    static void Swap(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
	static void Main()
    {
        double[] salaries = { 55000, 75000, 50000, 90000, 65000, 80000, 70000 };
        
        Console.WriteLine("Original Salaries: " + string.Join(", ", salaries));
        
        HeapSortSalaries(salaries);
        
        Console.WriteLine("Sorted Salaries: " + string.Join(", ", salaries));
    }
}
