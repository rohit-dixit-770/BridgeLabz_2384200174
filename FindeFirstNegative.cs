using System;

class Program{
	static int FindeFirstNegative(int[] arr){
		for(int i=0; i<arr.Length; i++){
			if(arr[i]<0){
				return arr[i];
			}
		}
		return int.MaxValue;
	}
	static void Main(){
		int [] number = {3,7,2,-5,8,-1,10};
		
		int firstNegative = FindeFirstNegative(number);
		
		if(firstNegative == int.MaxValue){
			Console.WriteLine("No negative number found in the array");
		}else{
			Console.WriteLine("First negative number: "+firstNegative);
		}
	}
}