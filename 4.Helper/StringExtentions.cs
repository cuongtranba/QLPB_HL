
using System;

namespace _4.Helper
{
    public static class StringExtentions
    {
        public static string ToMD5(this string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider md5Hasher = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] hashedBytes;
            System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
            hashedBytes = md5Hasher.ComputeHash(encoder.GetBytes(input));
            var md5Encrypt = BitConverter.ToString(hashedBytes).Replace("-", "").ToLower();
            return md5Encrypt;
        }
    }
}
