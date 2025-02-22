using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_Assignment_5and6_Testing
{
    public class FileHandling
    {
        public class FileProcessor
        {
            public void WriteToFile(string filename, string content)
            {
                File.WriteAllText(filename, content);
            }

            public string ReadFromFile(string filename)
            {
                if (!File.Exists(filename))
                    throw new IOException("File not found");

                return File.ReadAllText(filename);
            }
        }

    }
}
