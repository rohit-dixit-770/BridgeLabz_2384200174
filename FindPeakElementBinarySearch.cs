using System;

class Program{
	static int FindPeakElement(int[] arr){
		int low  = 0, high = arr.Length-1;
		
		while(low < high){
			int mid = low +(high -low)/2;
			
			if(arr[mid] > arr[mid+1]){
				high = mid; // peak is on the left side
			}
			else{
				low = mid+1; //peak is on the right side
			}
		}
		return low;
	}
	static void Main(){
		int[] numbers = {1,3,5,4,2};
		int peakIndex = FindPeakElement(numbers);
		Console.WriteLine("Peak element is at index: "+peakIndex);
		Console.WriteLine("Peak element value: "+ numbers[peakIndex]);
	}
}