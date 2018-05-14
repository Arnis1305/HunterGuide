using System;
using System.Security.Cryptography;
using System.Text;

namespace HunterGuide.Helpers
{
    public static class HashGenerator
    {
        public static string GenerateHash(string value)
        {
            using (var sha = SHA256.Create())
            {
                var computedHash = sha.ComputeHash(Encoding.Unicode.GetBytes(value));
                return Convert.ToBase64String(computedHash);
            }
        }
    }
}
