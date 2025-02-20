using System;

class Program{
	static bool SearchMatrix(int[,] matrix, int target){
		int rows = matrix.GetLength(0);
		int cols = matrix.GetLength(1);
		int low = 0, high = rows*cols -1;
		
		while(low<=high){
			int mid = low + (high-low)/2;
			int row = mid/cols;
			int col = mid%cols;
			int midValue = matrix[row,col];
			
			if(midValue == target){
				Console.WriteLine("Target found at: ("+row+", "+col+")");
				return true;
			}
			else if(midValue<target){
				low = mid+1;
			}
			else{
				high = mid-1;
			}
		}
		Console.WriteLine("Target not found in the matrix");
		return false;
	}
	static void Main(){
		int[,] matrix = {
			{1,3,5,7},
			{10,11,16,20},
			{23,30,34,60}
		};
		Console.Write("Enter the target value: ");
		int target = Convert.ToInt32(Console.ReadLine());
		
		SearchMatrix(matrix,target);
	}
}