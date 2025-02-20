using System;
using System.IO;

class Program{
	static void Main(){
		string filePath = "sample.txt";
		if(File.Exists(filePath)){
			using(StreamReader reader = new StreamReader(filePath)){
				string line;
				while((line = reader.ReadLine()) != null){
					Console.WriteLine(line);
				}
			}
		}
		else{
			Console.WriteLine("Error: File does not exist");
		}	
			
	}
}