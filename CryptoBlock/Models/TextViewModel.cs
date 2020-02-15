using System.Collections.Generic;

namespace CryptoBlock.Models
{
    public class TextViewModel
    {
        public TextViewModel()
        {
            Base64Key = string.Empty;
            FilePath = string.Empty;
            FileStatus = FileStatus.Null;
            FileContent = new List<string>();
        }

        /// <summary>
        /// Encrypted password as Base64 string
        /// </summary>
        public string Base64Key { get; set; }

        /// <summary>
        /// File path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// File Status
        /// </summary>
        public FileStatus FileStatus { get; set; }

        /// <summary>
        /// File content
        /// </summary>
        public List<string> FileContent { get; set; }
    }
}
