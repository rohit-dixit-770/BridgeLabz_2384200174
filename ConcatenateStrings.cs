using System;
using System.Text;

class Program{
	static string ConcatenateStrings(string[] arr){
		StringBuilder sb = new StringBuilder();
		
		foreach(string word in arr){
			sb.Append(word).Append(" "); // add space between word
		}
		return sb.ToString().Trim();
	}
	static void Main(){
		string[] words = {"Hello","Everyone","I","am","Vansh"};
		Console.WriteLine("Concatenated String: "+ConcatenateStrings(words));
	}
}