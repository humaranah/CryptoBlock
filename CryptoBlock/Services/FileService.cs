using System.Collections.Generic;
using System.IO;

namespace CryptoBlock.Services
{
    public class FileService
    {
        /// <summary>
        /// Read the contents of a file
        /// </summary>
        /// <param name="filePath">Path of the file to read</param>
        /// <returns>The file content as a text list</returns>
        public List<string> ReadTextFile(string filePath)
        {
            List<string> content = new List<string>();
            using (TextReader text = new StreamReader(filePath))
            {
                while (text.Peek() >= 0)
                {
                    content.Add(text.ReadLine());
                }
            }

            return content;
        }

        /// <summary>
        /// Save the contents into a text file
        /// </summary>
        /// <param name="text">Text list to save</param>
        /// <param name="filePath">Path of file to save</param>
        public void SaveTextFile(string filePath, IEnumerable<string> text)
        {
            using (TextWriter writer = new StreamWriter(filePath))
            {
                foreach (string line in text)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
