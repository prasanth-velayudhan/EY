using System.IO;
namespace Ey.Common.Helpers
{
    using System;
    using System.Text;
    using System.Security.Cryptography;

    /// <summary>
    /// Helper class to decrypt the manage booking checksum parameter in the same way as Radixx
    /// </summary>
    public static class EncryptionHelper
    {
        /// <summary>
        /// Uses DES algorithm to decrypt
        /// </summary>
        /// <param name="text">Hexadecimal input string to decrypt</param>
        /// <param name="encryptionKey">password key used in decryption</param>
        /// <returns>UTF-8 string in following format: PAXNAME=PARDO&PNR=123ABC</returns>
        public static string Decrypt(string text, string encryptionKey)
        {
            var data = ToByteArray(text);
            var key = Encoding.UTF8.GetBytes(encryptionKey.Substring(0, 8));
            var iv = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0 };
            var result = new byte[0];

            using (var cryptoServiceProvider = new DESCryptoServiceProvider { Padding = PaddingMode.None })
            {
                using (var decryptor = cryptoServiceProvider.CreateDecryptor(key, iv))
                {
                    result = decryptor.TransformFinalBlock(data, 0, data.Length);
                }
            }

            return Encoding.UTF8.GetString(result);
        }

        /// <summary>
        /// Converts a hexadecimal string to a byte array
        /// </summary>
        /// <param name="hexString">hexadecimal input string</param>
        /// <returns>array of bytes</returns>
        public static byte[] ToByteArray(string hexString)
        {
            var length = hexString.Length;
            var result = new byte[length / 2];

            for (int i = 0; i < length; i += 2)
            {
                result[i / 2] = Convert.ToByte(hexString.Substring(i, 2), 16);
            }

            return result;
        }


        /// <summary>
        /// Uses DES algorithm to encrypt
        /// </summary>
        /// <param name="username">string username to encrypt</param>
        /// <param name="password">string password to encrypt</param>
        /// /// <param name="password">string public key to encrypt</param>
        /// <returns>string as query string</returns>
        public static string Encrypt(string username, string password, string key, string Portal)
        {

            byte[] abytKey = System.Text.Encoding.UTF8.GetBytes(key.Substring(0, 8));

            //set IV for DES decryption

            byte[] abytIV = { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

            // increase size of message to a multiple of 8

            string stringToEncrypt = "username=" + username + "&password=" + password + "&portalmainpage =" + Portal;
            stringToEncrypt += String.Empty.PadLeft(8 - (stringToEncrypt.Length % 8));

            // covert message to byte array
            byte[] abytMessage = Encoding.UTF8.GetBytes(stringToEncrypt);

            // initialize decryption stream

            DESCryptoServiceProvider objDES = new DESCryptoServiceProvider();
            objDES.Padding = PaddingMode.None;

            MemoryStream objStream = new MemoryStream();

            CryptoStream objCryptoStream = new CryptoStream(objStream, objDES.CreateEncryptor(abytKey, abytIV),
                               CryptoStreamMode.Write);

            // write to stream

            objCryptoStream.Write(abytMessage, 0, abytMessage.Length);
            objCryptoStream.FlushFinalBlock();

            objStream.Position = 0;
            string strReturn = "";

            //  convert bytes to hex-string
            StringBuilder hex = new StringBuilder(objStream.ToArray().Length * 2);
            foreach (byte b in objStream.ToArray())
            {

                hex.AppendFormat("{0:x2}", b);
                strReturn = hex.ToString();
            }

            return strReturn;
        }

        /// <summary>
        /// Use DES algorithm to encrypt(two level)
        /// </summary>
        /// <param name="username"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static string GetTAFinanceUrlChecksum(string username, string key)
        {
            string strReturn = "";
            key = key + "_" + DateTime.Today.Date.ToUniversalTime().ToString("ddMM") + "Ey" + DateTime.Today.Date.ToUniversalTime().ToString("yy");
            string stringToEncrypt = "username=" + username;
            string[] keyValues = key.Split('_');

            foreach (string val in keyValues)
            {
                byte[] abytKey = System.Text.Encoding.UTF8.GetBytes(val.Substring(0, 8));

                //set IV for DES decryption
                byte[] abytIV = { 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0, 0x0 };

                // increase size of message to a multiple of 8
                stringToEncrypt += String.Empty.PadLeft(8 - (stringToEncrypt.Length % 8));

                // covert message to byte array
                byte[] abytMessage = Encoding.UTF8.GetBytes(stringToEncrypt);

                // initialize decryption stream
                DESCryptoServiceProvider objDES = new DESCryptoServiceProvider();
                objDES.Padding = PaddingMode.None;

                MemoryStream objStream = new MemoryStream();
                CryptoStream objCryptoStream = new CryptoStream(objStream, objDES.CreateEncryptor(abytKey, abytIV),
                                   CryptoStreamMode.Write);

                // write to stream
                objCryptoStream.Write(abytMessage, 0, abytMessage.Length);
                objCryptoStream.FlushFinalBlock();

                objStream.Position = 0;
                strReturn = "";

                //  convert bytes to hex-string
                StringBuilder hex = new StringBuilder(objStream.ToArray().Length * 2);
                foreach (byte b in objStream.ToArray())
                {
                    hex.AppendFormat("{0:x2}", b);
                    strReturn = hex.ToString();
                }

                stringToEncrypt = strReturn;
            }

            return strReturn;
        }
    }
}
