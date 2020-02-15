using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System.Text;

namespace CryptoBlock.Models
{
    public class CryptoText
    {
        /// <summary>
        /// Importa un archivo
        /// </summary>
        /// <param name="archivo">Archivo a importar</param>
        /// <returns>Un texto con el contenido del archivo</returns>
        public static string[] Importar(string archivo)
        {
            List<string> ret = new List<string>();
            using (TextReader text = new StreamReader(archivo))
            {
                while (text.Peek() >= 0)
                {
                    ret.Add(text.ReadLine());
                }
            }
            return ret.ToArray();
        }

        /// <summary>
        /// Exporta el texto hacia un archivo
        /// </summary>
        /// <param name="texto">Texto a exportar</param>
        /// <param name="archivo">Archivo a crear</param>
        public static void Exportar(string[] texto, string archivo)
        {
            using (TextWriter text = new StreamWriter(archivo))
            {
                foreach (string linea in texto)
                {
                    text.WriteLine(linea);
                }
            }
        }

        /// <summary>
        /// Guarda el documento encriptado en un archivo
        /// </summary>
        /// <param name="texto">Texto a encriptar</param>
        /// <param name="contraseña">Contraseña para encriptar</param>
        /// <param name="ruta">Ruta del archivo a guardar</param>
        public static void Guardar(string[] texto, string contraseña, string ruta)
        {
            /*byte[] llave = EncriptarSHA256(contraseña);
            Data data = new Data();
            data.IV = VectorAleatorio();
            foreach (string linea in texto)
            {
                data.Texto.Add(EncriptarAES(linea, EncriptarSHA256(contraseña), data.IV));
            }
            using (Stream archivo = File.Create(ruta))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(archivo, data);
            }*/
            byte[] llave = EncriptarSHA256(contraseña);
            byte[] IV = VectorAleatorio();
            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine(Encoding.ASCII.GetString(IV));
                foreach (string linea in texto)
                {
                    sw.WriteLine(EncriptarAES(linea, llave, IV));
                }
            }
        }

        /// <summary>
        /// Abre un archivo y lo desencripta
        /// </summary>
        /// <param name="llave">Llave para desencriptar</param>
        /// <param name="ruta">Ruta del archivo</param>
        /// <returns>El texto desencriptado</returns>
        public static string[] Abrir(string contraseña, string ruta)
        {
            try // prueba el método antiguo
            {
                return abrirAntiguo(contraseña, ruta);
            }
            catch // abre con el nuevo método
            {
                byte[] llave = EncriptarSHA256(contraseña);
                byte[] IV = new byte[16];
                List<string> ret = new List<string>();
                using (StreamReader sr = new StreamReader(ruta))
                {
                    IV = System.Text.Encoding.ASCII.GetBytes(sr.ReadLine());
                    while (!sr.EndOfStream)
                    {
                        ret.Add(DesencriptarAES(sr.ReadLine(), llave, IV));
                    }
                }
                return ret.ToArray();
            }
        }

        /// <summary>
        /// Encripta un texto usando AES y lo envía a un flujo de memoria
        /// </summary>
        /// <param name="texto">Texto a encriptar</param>
        /// <param name="llave">Llave para la encriptación</param>
        /// <param name="IV">Vector de inicialización</param>
        /// <returns>Un flujo de memoria con el archivo encriptado</returns>
        public static string EncriptarAES(string texto, byte[] llave, byte[] IV)
        {
            byte[] textoBytes, encriptadoBytes;

            texto = "    " + texto;

            using (Rijndael aes = Rijndael.Create())
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(ms, aes.CreateEncryptor(llave, IV), CryptoStreamMode.Write))
                    {
                        textoBytes = Encoding.UTF32.GetBytes(texto);
                        csEncrypt.Write(textoBytes, 0, textoBytes.Length);
                        csEncrypt.FlushFinalBlock();
                        encriptadoBytes = ms.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encriptadoBytes);
        }

        /// <summary>
        /// Desencripta un texto desde un vector de bytes
        /// </summary>
        /// <param name="flujo">Flujo de memoria a desencriptar</param>
        /// <param name="llave">Llave necesaria para desencriptar</param>
        /// <param name="IV">Vector de inicialización</param>
        /// <param name="verifica">Cadena de verificación</param>
        /// <returns>El texto desencriptado</returns>
        public static string DesencriptarAES(string texto, byte[] llave, byte[] IV)
        {
            byte[] encriptadoBytes = Convert.FromBase64String(texto);
            byte[] textoBytes = new byte[encriptadoBytes.Length];
            int longitud = 0;
            string ret = null;

            using (Rijndael aes = Rijndael.Create())
            {
                using (MemoryStream flujo = new MemoryStream(encriptadoBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(flujo, aes.CreateDecryptor(llave, IV), CryptoStreamMode.Read))
                    {
                        longitud = csDecrypt.Read(textoBytes, 0, textoBytes.Length);
                    }
                }
            }

            ret = Encoding.UTF32.GetString(textoBytes, 0, longitud);
            return ret.Substring(4, ret.Length - 4);
        }

        /// <summary>
        /// Encripta un texto mediante el algoritmo SHA256
        /// </summary>
        /// <param name="entrada">Texto a encriptar</param>
        /// <returns>El texto encriptado en una cadena de bytes</returns>
        public static byte[] EncriptarSHA256(string entrada)
        {
            if (entrada == null)
                throw new ArgumentNullException("entrada");

            HashAlgorithm algoritmo = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.UTF8.GetBytes(entrada);
            byte[] hashedBytes = algoritmo.ComputeHash(inputBytes);

            return hashedBytes;
        }

        /// <summary>
        /// Genera un vector aleatorio de bytes
        /// </summary>
        /// <param name="tamaño">Tamaño del vector</param>
        /// <returns>Un vector aleatorio de tamaño dado</returns>
        public static byte[] VectorAleatorio(int tamaño = 16)
        {
            byte[] ret = new byte[tamaño];
            RandomNumberGenerator generator = RandomNumberGenerator.Create();
            generator.GetBytes(ret);
            return ret;
        }

        private static string[] abrirAntiguo(string contraseña, string ruta)
        {
            byte[] llave = EncriptarSHA256(contraseña);
            FileEncryptionData data = new FileEncryptionData();
            List<string> ret = new List<string>();
            using (Stream archivo = File.Open(ruta, FileMode.Open))
            {
                BinaryFormatter bf = new BinaryFormatter();
                data = (FileEncryptionData)bf.Deserialize(archivo);
            }
            foreach (string linea in data.Text)
            {
                ret.Add(DesencriptarAES(linea, EncriptarSHA256(contraseña), data.IV));
            }
            return ret.ToArray();
        }
    }
}
