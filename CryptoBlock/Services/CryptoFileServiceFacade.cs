using CryptoBlock.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CryptoBlock.Services
{
    public class CryptoFileServiceFacade
    {
        private readonly FileService _fileService;
        private readonly ShaCryptoService _shaService;
        private readonly RijndaelCryptoService _aesService;

        public CryptoFileServiceFacade(FileService fileService,
            ShaCryptoService shaService, RijndaelCryptoService aesService)
        {
            _fileService = fileService;
            _shaService = shaService;
            _aesService = aesService;
        }

        public List<string> LoadFile(string filePath, string base64key)
        {
            var key = Convert.FromBase64String(base64key);
            var contentLines = _fileService.ReadTextFile(filePath);
            var fileData = new FileEncryptionData(contentLines);
            var iv = fileData.GetInitVector();

            return fileData.TextLines
                .Select(line => _aesService.Decrypt(line, key, iv))
                .ToList();
        }

        public void SaveFile(string filePath, IEnumerable<string> lines, string base64key)
        {
            var key = Convert.FromBase64String(base64key);
            var iv = _aesService.GenerateInitVector();
            var fileData = new FileEncryptionData(iv)
            {
                TextLines = lines
                .Select(line => _aesService.Encrypt(line, key, iv))
                .ToList()
            };

            _fileService.SaveTextFile(filePath, fileData.ToFileContentLines());
        }

        public string EncryptPassword(string password)
        {
            var key = _shaService.Encrypt(password);
            return Convert.ToBase64String(key);
        }

        public List<string> ImportFromTextFile(string filePath) => _fileService.ReadTextFile(filePath);

        public void ExportToTextFile(string filePath, IEnumerable<string> lines) => _fileService.SaveTextFile(filePath, lines);
    }
}
