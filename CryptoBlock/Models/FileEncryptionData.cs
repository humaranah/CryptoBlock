using System;
using System.Collections.Generic;

namespace CryptoBlock.Models
{
    [Serializable]
    public class FileEncryptionData
    {
        public FileEncryptionData()
        {
            Text = new List<string>();
        }

        public byte[] IV { get; set; }

        public List<string> Text { get; set; }
    }
}
