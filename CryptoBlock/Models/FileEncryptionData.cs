using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoBlock.Models
{
    public sealed class FileEncryptionData
    {
        private readonly byte[] _initVector;

        private FileEncryptionData()
        {
            TextLines = new List<string>();
        }

        public FileEncryptionData(byte[] initVector) : this()
        {
            _initVector = initVector;
        }

        public FileEncryptionData(List<string> fileContentLines) : this()
        {
            _initVector = Convert.FromBase64String(fileContentLines.First());

            if (fileContentLines.Count > 1)
            {
                TextLines.AddRange(fileContentLines.Skip(1));
            }
        }

        public List<string> TextLines { get; set; }

        public byte[] GetInitVector()
        {
            return (byte[])_initVector.Clone();
        }

        public List<string> ToFileContentLines()
        {
            var contentList = new List<string> { Convert.ToBase64String(_initVector) };
            contentList.AddRange(TextLines);
            return contentList;
        }
    }
}
