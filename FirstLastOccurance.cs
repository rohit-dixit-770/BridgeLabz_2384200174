using System;

class Program{
	// binary search for first occurance
	static int FindFirstOccurance(int[] arr, int target){
		int low=0, high=arr.Length-1, result=-1;
		
		while(low<=high){
			int mid = low+(high-low)/2;
			
			if(arr[mid] == target){
				result = mid;
				high = mid - 1; // move left to find earlier occurance
			}
			else if(arr[mid] < target){
				low = mid+1; // move right
			}
			else{
				high = mid - 1;
			}
		}
		return result;
	}
	// binary search for last occurance
	static int FindLastOccurance(int[] arr, int target){
		int low = 0, high = arr.Length-1, result = -1;
		
		while(low <= high){
			int mid = low+(high-low)/2;
			
			if(arr[mid] == target){
				result = mid;
				low = mid +1; // move right to find later occurance
			}
			else if(arr[mid] < target){
				low = mid+1; // move right
			}
			else{
				high = mid -1;
			}
		}
		return result;
	}
	static void Main(){
		int[] sortedArray = {1,2,2,2,2,3,4,5,5,5,6};
		Console.Write("Enter the target value: ");
		int target = Convert.ToInt32(Console.ReadLine());
		
		int first = FindFirstOccurance(sortedArray,target);
		int last = FindLastOccurance(sortedArray,target);
		
		if(first == -1){
			Console.WriteLine("Element not found in the array");
		}else{
			Console.WriteLine("First Occurance at index: " + first);
			Console.WriteLine("Last Occurance at index: " + last);
		}
	}
}