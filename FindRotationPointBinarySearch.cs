using System;

class Program{
	static int FindRotationPoint(int[] arr){
		int low=0, high = arr.Length-1;
		
		while(low<high){
			int mid = low +(high - low)/2;
			if(arr[mid] > arr[high]){
				low = mid+1;
			}
			else{
				high = mid;
			}
		}
		return low; // low is the index of the smallest element
	}
	static void Main(){
		int[] rotatedArray = {4,5,6,7,1,2,3};
		
		int rotationIndex = FindRotationPoint(rotatedArray);
		Console.WriteLine("The rotation point is at index: " + rotationIndex);
        Console.WriteLine("Smallest element: " + rotatedArray[rotationIndex]);
	}
}