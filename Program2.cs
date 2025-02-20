using System;
using System.IO;  // Required for StreamReader

class Program {
    static void Main() {
        string filePath = "sample.txt";  // Change this path as needed

        try {
            using (StreamReader reader = new StreamReader(filePath)) {
                string line;
                while ((line = reader.ReadLine()) != null) {
                    Console.WriteLine(line);  // Print each line
                }
            }
        } catch (IOException ex) {
            Console.WriteLine("Error reading file: " + ex.Message);
        }
    }
}
