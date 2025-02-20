using System;
using System.Text;
using System.Diagnostics; // Required for Stopwatch

class Program {
    static void Main() {
        int iterations = 10000; // Number of times to concatenate
        string text = "Hello";

        // Measure time for string concatenation (+ operator)
        Stopwatch stopwatch = Stopwatch.StartNew();
        string result = "";
        for (int i = 0; i < iterations; i++) {
            result += text; // Inefficient concatenation
        }
        stopwatch.Stop();
        Console.WriteLine("String Concatenation Time: " + stopwatch.ElapsedMilliseconds + " ms");

        // Measure time for StringBuilder
        stopwatch.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < iterations; i++) {
            sb.Append(text); // Efficient concatenation
        }
        stopwatch.Stop();
        Console.WriteLine("StringBuilder Time: " + stopwatch.ElapsedMilliseconds + " ms");
    }
}
