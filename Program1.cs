using System;
using System.Text;  // Required for StringBuilder

class Program {
    static void Main() {
        // Create a StringBuilder with an initial string
        StringBuilder sb = new StringBuilder("Hello");

        // Append text
        sb.Append(" World");

        // Append a new line
        sb.AppendLine("!");

        // Insert text at a specific position
        sb.Insert(6, "Beautiful ");

        // Replace text
        sb.Replace("World", "C#");

        // Print final output
        Console.WriteLine(sb.ToString());
    }
}
