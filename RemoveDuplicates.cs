using System;
using System.Text;

class Program{
	static string RemoveDuplicates(string str){
		StringBuilder sb = new StringBuilder();
		bool[] seenChar = new bool[256];
		
		foreach(char c in str){
			if(!seenChar[c]){ // if character is unique
				sb.Append(c);
				seenChar[c] = true;
			}
		}
		return sb.ToString();
	}
	static void Main(){
		string str = "hello";
		Console.WriteLine("String after removing duplicates: "+RemoveDuplicates(str));
	}
}