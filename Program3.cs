using System;
using System.Diagnostics;
using System.Text;

class StringConcatenationComparison {
    // Inefficient String Concatenation (O(N²))
    static void StringConcatenation(int count) {
        string result = "";
        for (int i = 0; i < count; i++) {
            result += "a";  // Creates a new string object each time (very slow)
        }
    }

    // Efficient StringBuilder Concatenation (O(N))
    static void StringBuilderConcatenation(int count) {
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < count; i++) {
            sb.Append("a");  // Appends to the same buffer (fast)
        }
    }

    // Measure Execution Time
    static void MeasurePerformance(string method, Action action) {
        Stopwatch sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine(method+": "+sw.ElapsedMilliseconds+" ms");
    }
	static void Main() {
        int[] testSizes = { 1000, 10000, 1000000 };

        foreach (int size in testSizes) {
            Console.WriteLine("\nTesting with "+size+" concatenations:");

            MeasurePerformance("String (O(N²))", () => StringConcatenation(size));
            MeasurePerformance("StringBuilder (O(N))", () => StringBuilderConcatenation(size));
        }
    }
}
