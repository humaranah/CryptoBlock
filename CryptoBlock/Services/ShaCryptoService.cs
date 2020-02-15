using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace CryptoBlock.Services
{
    public class ShaCryptoService
    {
        /// <summary>
        /// Encrypts a text using SHA256 algorithm
        /// </summary>
        /// <param name="input">Text to encrypt</param>
        /// <returns>A byte array containining the encrypted text</returns>
        public byte[] Encrypt(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException(nameof(input));
            }

            var shaProvider = new SHA256CryptoServiceProvider();
            var inputBytes = Encoding.UTF8.GetBytes(input);
            return shaProvider.ComputeHash(inputBytes);
        }
    }
}
