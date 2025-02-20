using System;
using System.IO;
using System.Text;

class Program{
	static void Main(){
		string filePath = "utf8_sample.txt";
		
		try{
			using(StreamReader reader = new StreamReader(filePath, Encoding.UTF8)){
				string content = reader.ReadToEnd();
				Console.WriteLine("File Content:\n"+content);
			}
		}
		catch (IOException ex){
			Console.WriteLine("Error Reading file"+ex.Message); 
		}
	}
}