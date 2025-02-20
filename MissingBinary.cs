using System;

class Program {
    // Function to find the first missing positive integer using Linear Search
    static int FindFirstMissingPositive(int[] arr) {
        int n = arr.Length;
        
        // Step 1: Place each number in its correct index if possible
        for (int i = 0; i < n; i++) {
            while (arr[i] > 0 && arr[i] <= n && arr[arr[i] - 1] != arr[i]) {
                // Swap arr[i] with arr[arr[i] - 1]
                int temp = arr[arr[i] - 1];
                arr[arr[i] - 1] = arr[i];
                arr[i] = temp;
            }
        }

        // Step 2: Find the first missing positive number
        for (int i = 0; i < n; i++) {
            if (arr[i] != i + 1) {
                return i + 1;  // First missing positive integer
            }
        }

        return n + 1; // If all numbers are in place, return next positive integer
    }

    // Function to perform Binary Search
    static int BinarySearch(int[] arr, int target) {
        int low = 0, high = arr.Length - 1;

        while (low <= high) {
            int mid = low + (high - low) / 2;

            if (arr[mid] == target) {
                return mid;  // Found the target, return index
            }
            else if (arr[mid] < target) {
                low = mid + 1;  // Move right
            }
            else {
                high = mid - 1; // Move left
            }
        }
        return -1; // Target not found
    }

    static void Main() {
        int[] nums = { 3, 4, -1, 1 };
        int target = 4;

        // Find the first missing positive integer
        int missingPositive = FindFirstMissingPositive((int[])nums.Clone()); // Clone to preserve original array
        Console.WriteLine("First missing positive integer: " + missingPositive);

        // Sort the array before Binary Search
        Array.Sort(nums);
        Console.WriteLine("Sorted array: " + string.Join(", ", nums));

        // Find the target index using Binary Search
        int index = BinarySearch(nums, target);
        Console.WriteLine("Index of target " + target + ": " + index);
    }
}
