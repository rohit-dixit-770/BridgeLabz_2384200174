using System;

class QuickSort
{    
    static void QuickSortProductPrices(double[] arr, int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(arr, low, high);
            
            QuickSortProductPrices(arr, low, pivotIndex - 1);
            QuickSortProductPrices(arr, pivotIndex + 1, high);
        }
    }
    
    static int Partition(double[] arr, int low, int high)
    {
        double pivot = arr[high];
        int i = low - 1;
        
        for (int j = low; j < high; j++)
        {
            if (arr[j] <= pivot)
            {
                i++;
                Swap(ref arr[i], ref arr[j]);
            }
        }
        
        Swap(ref arr[i + 1], ref arr[high]);
        return i + 1;
    }
    
    static void Swap(ref double a, ref double b)
    {
        double temp = a;
        a = b;
        b = temp;
    }
	static void Main()
    {
        double[] productPrices = { 199.99, 49.50, 349.99, 129.99, 79.99, 159.49, 249.99 };
        
        Console.WriteLine("Original Product Prices: " + string.Join(", ", productPrices));
        
        QuickSortProductPrices(productPrices, 0, productPrices.Length - 1);
        
        Console.WriteLine("Sorted Product Prices: " + string.Join(", ", productPrices));
    }
}
