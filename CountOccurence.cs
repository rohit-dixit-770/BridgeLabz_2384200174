using System;
using System.IO;

class Program {
    static void Main() {
        string filePath = "sample.txt";  // File path
        string searchWord = "vansh";     // Word to count (case-insensitive)
        int count = 0;

        // Check if file exists before reading
	
		using (StreamReader reader = new StreamReader(filePath)) {
			string line;
			while ((line = reader.ReadLine()) != null) {
				string[] words = line.ToLower().Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
				
				foreach (string word in words) {
					if (word == searchWord.ToLower()) {
						count++;
					}
				}
			}
		}
		Console.WriteLine("The word: "+searchWord+" appears: "+count+" times in the file.");
	
    }
}
