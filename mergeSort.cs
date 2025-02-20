using System;

class MergeSort
{
    static void MergeSortBookPrices(double[] arr, int left, int right)
    {
        if (left < right)
        {
            int middle = (left + right) / 2;
            
            MergeSortBookPrices(arr, left, middle);
            MergeSortBookPrices(arr, middle + 1, right);
            
            Merge(arr, left, middle, right);
        }
    }
    
    static void Merge(double[] arr, int left, int middle, int right)
    {
        int leftSize = middle - left + 1;
        int rightSize = right - middle;
        
        double[] leftArray = new double[leftSize];
        double[] rightArray = new double[rightSize];
        
        Array.Copy(arr, left, leftArray, 0, leftSize);
        Array.Copy(arr, middle + 1, rightArray, 0, rightSize);
        
        int i = 0, j = 0, k = left;
        
        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
            {
                arr[k] = leftArray[i];
                i++;
            }
            else
            {
                arr[k] = rightArray[j];
                j++;
            }
            k++;
        }
        
        while (i < leftSize)
        {
            arr[k] = leftArray[i];
            i++; k++;
        }
        
        while (j < rightSize)
        {
            arr[k] = rightArray[j];
            j++; k++;
        }
    }
	static void Main()
    {
        double[] bookPrices = { 19.99, 5.49, 25.99, 12.89, 8.75, 15.30, 22.10 };
        
        Console.WriteLine("Original Book Prices: " + string.Join(", ", bookPrices));
        
        MergeSortBookPrices(bookPrices, 0, bookPrices.Length - 1);
        
        Console.WriteLine("Sorted Book Prices: " + string.Join(", ", bookPrices));
    }
}
