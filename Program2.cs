using System;
using System.Diagnostics;

class SortingComparison {
    // Bubble Sort (O(N²))
    static void BubbleSort(int[] arr) {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++) {
            for (int j = 0; j < n - i - 1; j++) {
                if (arr[j] > arr[j + 1]) {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }

    // Merge Sort (O(N log N))
    static void MergeSort(int[] arr) {
        if (arr.Length < 2) return;
        int mid = arr.Length / 2;
        int[] left = new int[mid];
        int[] right = new int[arr.Length - mid];

        Array.Copy(arr, 0, left, 0, mid);
        Array.Copy(arr, mid, right, 0, arr.Length - mid);

        MergeSort(left);
        MergeSort(right);
        Merge(arr, left, right);
    }

    static void Merge(int[] arr, int[] left, int[] right) {
        int i = 0, j = 0, k = 0;
        while (i < left.Length && j < right.Length)
            arr[k++] = (left[i] < right[j]) ? left[i++] : right[j++];
        while (i < left.Length) arr[k++] = left[i++];
        while (j < right.Length) arr[k++] = right[j++];
    }

    // Quick Sort (O(N log N))
    static void QuickSort(int[] arr, int low, int high) {
        if (low < high) {
            int pi = Partition(arr, low, high);
            QuickSort(arr, low, pi - 1);
            QuickSort(arr, pi + 1, high);
        }
    }

    static int Partition(int[] arr, int low, int high) {
        int pivot = arr[high];
        int i = low - 1;
        for (int j = low; j < high; j++) {
            if (arr[j] <= pivot) {
                i++;
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }
        int temp2 = arr[i + 1];
        arr[i + 1] = arr[high];
        arr[high] = temp2;
        return i + 1;
    }

    // Generate Random Dataset
    static int[] GenerateDataset(int size) {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = rand.Next(size * 2);
        return arr;
    }

    // Measure Execution Time
    static void MeasureSortingTime(string name, Action sortMethod) {
        Stopwatch sw = Stopwatch.StartNew();
        sortMethod();
        sw.Stop();
        Console.WriteLine(name+": "+sw.ElapsedMilliseconds+" ms");
    }
	static void Main() {
        int[] datasetSizes = { 1000, 10000, 1000000 };

        foreach (int size in datasetSizes) {
            Console.WriteLine("\nDataset Size: "+size);

            int[] data = GenerateDataset(size);

            // Bubble Sort (O(N²)) - Skipped for large sizes
            if (size <= 10000) {
                int[] bubbleData = (int[])data.Clone();
                MeasureSortingTime("Bubble Sort", () => BubbleSort(bubbleData));
            } else {
                Console.WriteLine("Bubble Sort skipped (too slow)");
            }      

            // Merge Sort (O(N log N))
            int[] mergeData = (int[])data.Clone();
            MeasureSortingTime("Merge Sort", () => MergeSort(mergeData));

            // Quick Sort (O(N log N))
            int[] quickData = (int[])data.Clone();
            MeasureSortingTime("Quick Sort", () => QuickSort(quickData, 0, quickData.Length - 1));
        }
    }
}
