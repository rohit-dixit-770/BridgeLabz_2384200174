
//1. File Handling - Read and Write a Text File

using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Requesting the source file path from the user
        Console.Write("Enter the source file path: ");
        string sourceFilePath = Console.ReadLine();

        // Requesting the destination file path from the user
        Console.Write("Enter the destination file path: ");
        string destFilePath = Console.ReadLine();

        try
        {
            // Checking if the source file exists
            if (!File.Exists(sourceFilePath))
            {
                Console.WriteLine("The source file does not exist.");
                return;
            }

            // Reading the contents of the source file
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (StreamReader reader = new StreamReader(sourceStream))
            {
                string fileContent = reader.ReadToEnd();

                // Writing the contents to the destination file
                using (FileStream destStream = new FileStream(destFilePath, FileMode.Create, FileAccess.Write))
                using (StreamWriter writer = new StreamWriter(destStream))
                {
                    writer.Write(fileContent);
                }
            }

            Console.WriteLine("File has been successfully copied.");
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
    }
}


//2. Buffered Streams - Efficient File Copy
using System;
using System.Diagnostics;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Requesting the source file path from the user
        Console.Write("Enter the source file path: ");
        string sourceFilePath = Console.ReadLine();

        // Requesting the destination file path for buffered stream
        Console.Write("Enter the destination file path for buffered stream: ");
        string destFilePathBuffered = Console.ReadLine();

        // Requesting the destination file path for unbuffered stream
        Console.Write("Enter the destination file path for unbuffered stream: ");
        string destFilePathUnbuffered = Console.ReadLine();

        // Copy using BufferedStream
        Stopwatch stopwatch = new Stopwatch();
        stopwatch.Start();
        CopyFileUsingBufferedStream(sourceFilePath, destFilePathBuffered);
        stopwatch.Stop();
        Console.WriteLine($"BufferedStream copy time: {stopwatch.ElapsedMilliseconds} ms");

        // Copy using normal FileStream
        stopwatch.Reset();
        stopwatch.Start();
        CopyFileUsingFileStream(sourceFilePath, destFilePathUnbuffered);
        stopwatch.Stop();
        Console.WriteLine($"Unbuffered FileStream copy time: {stopwatch.ElapsedMilliseconds} ms");
    }

    static void CopyFileUsingBufferedStream(string sourceFilePath, string destFilePath)
    {
        using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destFilePath, FileMode.Create, FileAccess.Write))
        using (BufferedStream bufferedStream = new BufferedStream(destStream, 4096))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                bufferedStream.Write(buffer, 0, bytesRead);
            }
        }
    }

    static void CopyFileUsingFileStream(string sourceFilePath, string destFilePath)
    {
        using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
        using (FileStream destStream = new FileStream(destFilePath, FileMode.Create, FileAccess.Write))
        {
            byte[] buffer = new byte[4096];
            int bytesRead;
            while ((bytesRead = sourceStream.Read(buffer, 0, buffer.Length)) > 0)
            {
                destStream.Write(buffer, 0, bytesRead);
            }
        }
    }
}


//3. Read User Input from Console
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            // Requesting the user's information
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            Console.Write("Enter your favorite programming language: ");
            string favoriteLanguage = Console.ReadLine();

            // Writing the information to a file
            using (StreamWriter writer = new StreamWriter("user_info.txt"))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Favorite Programming Language: " + favoriteLanguage);
            }

            Console.WriteLine("User information has been saved to 'user_info.txt'.");
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}


//4. Serialization - Save and Retrieve an Object
using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }

    public Employee(int id, string name, string department, double salary)
    {
        Id = id;
        Name = name;
        Department = department;
        Salary = salary;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // List to store employees
        List<Employee> employees = new List<Employee>();

        // Adding some employees to the list
        employees.Add(new Employee(1, "Mohit", "HR", 50000));
        employees.Add(new Employee(2, "Tushar", "Finance", 60000));
        employees.Add(new Employee(3, "Monu", "IT", 70000));

        // File path for serialization
        string filePath = "employees.dat";

        try
        {
            // Serialize the list of employees
            SerializeEmployees(filePath, employees);
            Console.WriteLine("Employees have been serialized.");

            // Deserialize the list of employees
            List<Employee> deserializedEmployees = DeserializeEmployees(filePath);
            Console.WriteLine("Employees have been deserialized.");

            // Display the deserialized employees
            foreach (var employee in deserializedEmployees)
            {
                Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Department: {employee.Department}, Salary: {employee.Salary}");
            }
        }
        catch (SerializationException ex)
        {
            Console.WriteLine($"Serialization error: {ex.Message}");
        }
        catch (IOException ex)
        {
            Console.WriteLine($"I/O error: {ex.Message}");
        }
    }

    static void SerializeEmployees(string filePath, List<Employee> employees)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(fileStream, employees);
        }
    }

    static List<Employee> DeserializeEmployees(string filePath)
    {
        using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            return (List<Employee>)formatter.Deserialize(fileStream);
        }
    }
}


//5. ByteArray Stream - Convert Image to ByteArray
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Requesting the source image file path from the user
        Console.Write("Enter the source image file path: ");
        string sourceFilePath = Console.ReadLine();

        // Requesting the destination image file path from the user
        Console.Write("Enter the destination image file path: ");
        string destFilePath = Console.ReadLine();

        try
        {
            // Convert image to byte array
            byte[] imageBytes = File.ReadAllBytes(sourceFilePath);

            // Write byte array back to an image file
            File.WriteAllBytes(destFilePath, imageBytes);

            Console.WriteLine("Image has been successfully copied.");

            // Verify that the new file is identical to the original image
            byte[] newImageBytes = File.ReadAllBytes(destFilePath);
            bool areFilesIdentical = CompareByteArrays(imageBytes, newImageBytes);

            if (areFilesIdentical)
            {
                Console.WriteLine("The new file is identical to the original image.");
            }
            else
            {
                Console.WriteLine("The new file is not identical to the original image.");
            }
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
    }

    static bool CompareByteArrays(byte[] array1, byte[] array2)
    {
        if (array1.Length != array2.Length)
        {
            return false;
        }

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i] != array2[i])
            {
                return false;
            }
        }

        return true;
    }
}


//6. Filter Streams - Convert Uppercase to Lowercase
using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        // Requesting the source file path from the user
        Console.Write("Enter the source file path: ");
        string sourceFilePath = Console.ReadLine();

        // Requesting the destination file path from the user
        Console.Write("Enter the destination file path: ");
        string destFilePath = Console.ReadLine();

        try
        {
            // Reading the contents of the source file and converting to lowercase
            using (FileStream sourceStream = new FileStream(sourceFilePath, FileMode.Open, FileAccess.Read))
            using (BufferedStream bufferedSourceStream = new BufferedStream(sourceStream))
            using (StreamReader reader = new StreamReader(bufferedSourceStream, Encoding.UTF8))
            {
                string fileContent = reader.ReadToEnd().ToLower();

                // Writing the contents to the destination file
                using (FileStream destStream = new FileStream(destFilePath, FileMode.Create, FileAccess.Write))
                using (BufferedStream bufferedDestStream = new BufferedStream(destStream))
                using (StreamWriter writer = new StreamWriter(bufferedDestStream, Encoding.UTF8))
                {
                    writer.Write(fileContent);
                }
            }

            Console.WriteLine("File has been successfully processed and written to the destination file.");
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}


//7. Data Streams - Store and Retrieve Primitive Data
using System;
using System.Collections.Generic;
using System.IO;

[Serializable]
class Student
{
    public int RollNumber { get; set; }
    public string Name { get; set; }
    public double GPA { get; set; }

    public Student(int rollNumber, string name, double gpa)
    {
        RollNumber = rollNumber;
        Name = name;
        GPA = gpa;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Requesting the file path for storing student details
        Console.Write("Enter the file path to store student details: ");
        string filePath = Console.ReadLine();

        // Creating a list of students
        var students = new List<Student>
        {
            new Student(1, "Anil", 3.8),
            new Student(2, "Bobby", 3.5),
            new Student(3, "Mohit", 3.9)
        };

        try
        {
            // Writing student details to a binary file
            using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            using (BinaryWriter writer = new BinaryWriter(fileStream))
            {
                foreach (var student in students)
                {
                    writer.Write(student.RollNumber);
                    writer.Write(student.Name);
                    writer.Write(student.GPA);
                }
            }

            Console.WriteLine("Student details have been successfully written to the file.");

            // Reading student details from the binary file
            using (FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                while (reader.BaseStream.Position != reader.BaseStream.Length)
                {
                    int rollNumber = reader.ReadInt32();
                    string name = reader.ReadString();
                    double gpa = reader.ReadDouble();

                    Console.WriteLine($"Roll Number: {rollNumber}, Name: {name}, GPA: {gpa}");
                }
            }
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}



//8. Piped Streams - Inter-Thread Communication
using System;
using System.IO;
using System.IO.Pipes;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        // Creating a Named Pipe for communication
        using (var pipeServer = new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable))
        using (var pipeClient = new AnonymousPipeClientStream(PipeDirection.In, pipeServer.GetClientHandleAsString()))
        {
            // Creating and starting the writer thread
            Thread writerThread = new Thread(() => WriteToPipe(pipeServer));
            writerThread.Start();

            // Creating and starting the reader thread
            Thread readerThread = new Thread(() => ReadFromPipe(pipeClient));
            readerThread.Start();

            // Waiting for both threads to complete
            writerThread.Join();
            readerThread.Join();
        }
    }

    static void WriteToPipe(Stream pipeStream)
    {
        try
        {
            using (StreamWriter writer = new StreamWriter(pipeStream))
            {
                writer.AutoFlush = true;
                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine($"Message {i}");
                    Thread.Sleep(100); // Simulating some delay
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Write error: {ex.Message}");
        }
    }

    static void ReadFromPipe(Stream pipeStream)
    {
        try
        {
            using (StreamReader reader = new StreamReader(pipeStream))
            {
                string message;
                while ((message = reader.ReadLine()) != null)
                {
                    Console.WriteLine($"Received: {message}");
                }
            }
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Read error: {ex.Message}");
        }
    }
}


//9. Read a Large File Line by Line
using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        // Requesting the source file path from the user
        Console.Write("Enter the path of the large text file: ");
        string filePath = Console.ReadLine();

        try
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    if (line.IndexOf("error", StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        Console.WriteLine(line);
                    }
                }
            }

            Console.WriteLine("File reading completed.");
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}


//10. Count Words in a File
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Requesting the file path from the user
        Console.Write("Enter the path of the text file: ");
        string filePath = Console.ReadLine();

        try
        {
            // Dictionary to store word occurrences
            Dictionary<string, int> wordCount = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);

            // Reading the file and counting word occurrences
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] words = line.Split(new char[] { ' ', '\t', '\n', '\r', ',', '.', ';', ':', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
                    foreach (string word in words)
                    {
                        if (wordCount.ContainsKey(word))
                        {
                            wordCount[word]++;
                        }
                        else
                        {
                            wordCount[word] = 1;
                        }
                    }
                }
            }

            // Sorting words based on frequency and displaying the top 5
            var topWords = wordCount.OrderByDescending(w => w.Value).Take(5);
            Console.WriteLine("Top 5 most frequently occurring words:");
            foreach (var word in topWords)
            {
                Console.WriteLine($"{word.Key}: {word.Value} times");
            }
        }
        catch (IOException ex)
        {
            // Handling IOException
            Console.WriteLine($"An I/O error occurred: {ex.Message}");
        }
        catch (Exception ex)
        {
            // Handling any other exceptions
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}