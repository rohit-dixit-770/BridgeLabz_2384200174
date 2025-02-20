using System;
using System.Diagnostics;
using System.IO;
using System.Text;

class FileReadingComparison {
    // StreamReader - Reads line by line (good for text files)
    static void ReadWithStreamReader(string path) {
        using (StreamReader sr = new StreamReader(path, Encoding.UTF8)) {
            while (sr.ReadLine() != null) { } // Read file line by line
        }
    }

    // FileStream - Reads in byte chunks (better for binary files)
    static void ReadWithFileStream(string path) {
        byte[] buffer = new byte[8192]; // 8KB buffer
        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read)) {
            while (fs.Read(buffer, 0, buffer.Length) > 0) { } // Read in chunks
        }
    }

    // Measure Execution Time
    static void MeasurePerformance(string method, Action action) {
        Stopwatch sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine($"{method}: {sw.ElapsedMilliseconds} ms");
    }

    // Generate a Large Test File (for testing)
    static void GenerateLargeFile(string path, int sizeInBytes) {
        byte[] data = new byte[1024 * 1024]; // 1MB chunk
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write)) {
            for (int i = 0; i < sizeInBytes / data.Length; i++) {
                fs.Write(data, 0, data.Length);
            }
        }
        Console.WriteLine("Large file generated successfully.");
    }
	static void Main() {
        string filePath = "largefile.txt"; // Change to a real large file

        if (!File.Exists(filePath)) {
            Console.WriteLine("Generating a large test file (500MB)...");
            GenerateLargeFile(filePath, 500 * 1024 * 1024); // 500MB file
        }

        Console.WriteLine("\nMeasuring File Reading Performance:");

        MeasurePerformance("StreamReader (Text-Based)", () => ReadWithStreamReader(filePath));
        MeasurePerformance("FileStream (Byte-Based)", () => ReadWithFileStream(filePath));
    }
}
