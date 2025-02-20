using System;
using System.Diagnostics;

class FibonacciComparison {
    // Inefficient Recursive Fibonacci (O(2^N))
    static int FibonacciRecursive(int n) {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    // Efficient Iterative Fibonacci (O(N))
    static int FibonacciIterative(int n) {
        if (n <= 1) return n;
        int a = 0, b = 1, sum;
        for (int i = 2; i <= n; i++) {
            sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    // Measure Execution Time
    static void MeasureTime(string method, Action action) {
        Stopwatch sw = Stopwatch.StartNew();
        action();
        sw.Stop();
        Console.WriteLine($"{method}: {sw.ElapsedMilliseconds} ms");
    }
	static void Main() {
        int[] testValues = { 10, 30, 50 };

        foreach (int n in testValues) {
            Console.WriteLine($"\nComputing Fibonacci({n}):");

            MeasureTime("Recursive (O(2^N))", () => Console.WriteLine(FibonacciRecursive(n)));
            MeasureTime("Iterative (O(N))", () => Console.WriteLine(FibonacciIterative(n)));
        }
    }
}
