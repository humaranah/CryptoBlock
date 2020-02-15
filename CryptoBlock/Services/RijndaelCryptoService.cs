using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoBlock.Services
{
    public class RijndaelCryptoService
    {
        private const int DefaultVectorSize = 16;

        /// <summary>
        /// Encrypts a text using AES algorithm
        /// </summary>
        /// <param name="text">Text to encrypt</param>
        /// <param name="key">Encryption key</param>
        /// <param name="iv">Init vector</param>
        /// <returns>A string containing the encrypted text</returns>
        public string Encrypt(string text, byte[] key, byte[] iv)
        {
            byte[] encryptedBytes;
            var textInBytes = Encoding.UTF32.GetBytes($"    {text}");

            using (MemoryStream memoryStream = new MemoryStream())
            {
                using (Rijndael rijndael = Rijndael.Create())
                using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateEncryptor(key, iv), CryptoStreamMode.Write))
                {
                    cryptoStream.Write(textInBytes, 0, textInBytes.Length);
                    cryptoStream.FlushFinalBlock();
                }

                encryptedBytes = memoryStream.ToArray();
            }

            return Convert.ToBase64String(encryptedBytes);
        }

        /// <summary>
        /// Decrypts a text from a byte array using AES algorithm
        /// </summary>
        /// <param name="encryptedText">Encrypted text as <code>Base64String</code></param>
        /// <param name="key">Decryption key</param>
        /// <param name="iv">Init vector</param>
        /// <returns>A string containing the decrypted text</returns>
        public string Decrypt(string encryptedText, byte[] key, byte[] iv)
        {
            var encryptedBytes = Convert.FromBase64String(encryptedText);
            var textInBytes = new byte[encryptedBytes.Length];
            var length = 0;

            using (Rijndael rijndael = Rijndael.Create())
            using (MemoryStream memoryStream = new MemoryStream(encryptedBytes))
            using (CryptoStream cryptoStream = new CryptoStream(memoryStream, rijndael.CreateDecryptor(key, iv), CryptoStreamMode.Read))
            {
                length = cryptoStream.Read(textInBytes, 0, textInBytes.Length);
            }

            var decryptedText = Encoding.UTF32.GetString(textInBytes, 0, length);
            return decryptedText.Substring(4, decryptedText.Length - 4);
        }

        public byte[] CreateEmptyInitVector()
        {
            return new byte[DefaultVectorSize];
        }

        /// <summary>
        /// Generates a random init vector
        /// </summary>
        /// <param name="size">Vector size</param>
        /// <returns>An init vector with the specified size</returns>
        public byte[] GenerateInitVector()
        {
            var iv = CreateEmptyInitVector();
            var generator = RandomNumberGenerator.Create();
            generator.GetBytes(iv);
            return iv;
        }
    }
}
