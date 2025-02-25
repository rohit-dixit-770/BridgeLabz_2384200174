using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Week_5_Assignment_1
{
    internal class EncryptDecrypt
    {
        static readonly string Key = "0123456789abcdef";

        public void EncryptAndDecrypt()
        {
            string filePath = "data.csv";

            // Sample data
            string[] lines = {
            "ID,Name,Email,Salary",
            "1,John,john@example.com,50000",
            "2,Alice,alice@example.com,60000"
        };

            // Encrypt and write CSV
            EncryptAndWriteCSV(filePath, lines);

            // Read and decrypt CSV
            ReadAndDecryptCSV(filePath);
        }


        static void EncryptAndWriteCSV(string filePath, string[] lines)
        {
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                writer.WriteLine(lines[0]); // Write header

                for (int i = 1; i < lines.Length; i++)
                {
                    var parts = lines[i].Split(',');
                    parts[2] = Encrypt(parts[2]); // Encrypt Email
                    parts[3] = Encrypt(parts[3]); // Encrypt Salary
                    writer.WriteLine(string.Join(",", parts));
                }
            }
            Console.WriteLine("CSV Encrypted and Saved.");
        }

        static void ReadAndDecryptCSV(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var parts = line.Split(',');
                    if (parts[0] != "ID") // Skip header
                    {
                        parts[2] = Decrypt(parts[2]); // Decrypt Email
                        parts[3] = Decrypt(parts[3]); // Decrypt Salary
                    }
                    Console.WriteLine(string.Join(",", parts));
                }
            }
        }

        static string Encrypt(string text)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = new byte[16]; // Zero IV (simplified)

                using (var encryptor = aes.CreateEncryptor())
                {
                    byte[] buffer = Encoding.UTF8.GetBytes(text);
                    return Convert.ToBase64String(encryptor.TransformFinalBlock(buffer, 0, buffer.Length));
                }
            }
        }

        static string Decrypt(string encryptedText)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Key = Encoding.UTF8.GetBytes(Key);
                aes.IV = new byte[16];

                using (var decryptor = aes.CreateDecryptor())
                {
                    byte[] buffer = Convert.FromBase64String(encryptedText);
                    return Encoding.UTF8.GetString(decryptor.TransformFinalBlock(buffer, 0, buffer.Length));
                }
            }
        }
    }
}
