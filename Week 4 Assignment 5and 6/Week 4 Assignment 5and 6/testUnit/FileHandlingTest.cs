using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Week_4_Assignment_5and6_Testing.FileHandling;

namespace testUnit
{
    [TestFixture]
    public class FileProcessorTests
    {
        private readonly string testFile = "testfile.txt";

        [Test]
        public void WriteToFile_ShouldCreateFileAndWriteContent()
        {
            var processor = new FileProcessor();
            string content = "Hello, World!";

            processor.WriteToFile(testFile, content);

            Assert.IsTrue(File.Exists(testFile));
            Assert.AreEqual(content, File.ReadAllText(testFile));
        }

        [Test]
        public void ReadFromFile_ShouldReadContentCorrectly()
        {
            var processor = new FileProcessor();
            string content = "Test content";
            File.WriteAllText(testFile, content);

            string result = processor.ReadFromFile(testFile);

            Assert.AreEqual(content, result);
        }

        [Test]
        public void ReadFromFile_ShouldThrowIOException_WhenFileDoesNotExist()
        {
            var processor = new FileProcessor();

            Assert.Throws<IOException>(() => processor.ReadFromFile("nonexistent.txt"));
        }
    }

}
