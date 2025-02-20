using System;
using System.Diagnostics;

class SearchComparison {
    // Linear Search (O(N))
    static int LinearSearch(int[] arr, int target) {
        for (int i = 0; i < arr.Length; i++) {
            if (arr[i] == target) return i;
        }
        return -1;
    }

    // Binary Search (O(log N))
    static int BinarySearch(int[] arr, int target) {
        int left = 0, right = arr.Length - 1;
        while (left <= right) {
            int mid = left + (right - left) / 2;
            if (arr[mid] == target) return mid;
            else if (arr[mid] < target) left = mid + 1;
            else right = mid - 1;
        }
        return -1;
    }

    // Generate Random Dataset
    static int[] GenerateDataset(int size) {
        Random rand = new Random();
        int[] arr = new int[size];
        for (int i = 0; i < size; i++) arr[i] = rand.Next(1, size * 2);
        return arr;
    }
	static void Main() {
        int[] datasetSizes = { 1000, 10000, 1000000 };

        foreach (int size in datasetSizes) {
            Console.WriteLine("\nDataset Size: "+size);

            // Generate Random Dataset
            int[] data = GenerateDataset(size);
            int target = data[data.Length - 1]; // Choose last element (worst case)

            // Linear Search
            Stopwatch stopwatch = Stopwatch.StartNew();
            int linearIndex = LinearSearch(data, target);
            stopwatch.Stop();
            Console.WriteLine("Linear Search Time: "+stopwatch.ElapsedMilliseconds+" ms");

            // Binary Search (Sorting first)
            Array.Sort(data); // Sorting takes O(N log N)
            stopwatch.Restart();
            int binaryIndex = BinarySearch(data, target);
            stopwatch.Stop();
            Console.WriteLine("Binary Search Time: "+stopwatch.ElapsedMilliseconds+" ms");
        }
    }

}
