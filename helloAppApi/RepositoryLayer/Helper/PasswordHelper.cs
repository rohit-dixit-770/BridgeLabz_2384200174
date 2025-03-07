using System;
using System.Security.Cryptography;
using System.Text;

namespace RepositoryLayer.Helper
{
    public static class PasswordHelper
    {
        private const int SaltSize = 16; 
        private const int HashSize = 32; 
        private const int Iterations = 10000;

        public static string HashPassword(string password, out string salt)
        {
            byte[] saltBytes = new byte[SaltSize];
            using (var rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(saltBytes); 
            }

            var hashBytes = HashWithSalt(password, saltBytes);
            salt = Convert.ToBase64String(saltBytes);
            return Convert.ToBase64String(hashBytes);
        }

        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            var saltBytes = Convert.FromBase64String(storedSalt);
            var hashBytes = HashWithSalt(password, saltBytes);

            return Convert.ToBase64String(hashBytes) == storedHash;
        }

        private static byte[] HashWithSalt(string password, byte[] saltBytes)
        {
            using (var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, Iterations, HashAlgorithmName.SHA256))
            {
                return pbkdf2.GetBytes(HashSize);
            }
        }
    }
}
