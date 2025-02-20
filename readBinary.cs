using System;
using System.IO;
using System.Text;

class Program {
    static void Main() {
        string filePath = "sample.bin"; // Binary file to read

		using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
		using (StreamReader reader = new StreamReader(fs, Encoding.UTF8)) {
			string content = reader.ReadToEnd(); // Read entire content as characters
			Console.WriteLine("File Content:\n" + content);
		}
       
    }
}
