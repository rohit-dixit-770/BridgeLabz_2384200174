using System;
using System.Text;

class Program{
	static string ReverseString(string str){
		StringBuilder sb = new StringBuilder(str);
		int start = 0, end = sb.Length-1;
		
		while(start<end){
			char temp = sb[start];
			sb[start] = sb[end];
			sb[end] = temp;
			
			start++;
			end--;
		}
		return sb.ToString();
	}
	static void Main(){
		string str = "hello";
		Console.WriteLine("Reversed string: "+ReverseString(str));
	}
}