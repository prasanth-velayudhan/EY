using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Security.Cryptography;
using System;
using System.Data.HashFunction;
using Newtonsoft.Json;
using Ey.Common.Logging;

namespace Ey.Common
{
    public class HashService : IHashService
    {
        private static readonly ILog Logger = LogProvider.GetCurrentClassLogger();
        //Encryption key
        //public static byte[] Key = new byte[]{0x43, 0x72, 0x6e, 0x6d, 0x54, 0x4d, 0x65,
        //                              0x94, 0x16, 0x32, 0x44, 0x84, 0x7e, 0x18,
        //                              0x64, 0x76, 0x6e, 0x63, 0x64, 0x7a, 0x5f,
        //                              0x84, 0x7f, 0x9a};                                                        // get from config
        public static byte[] Key
        {
            get
            {
                if(_key == null)
                {
                    _key = GetKey();
                }
                return _key;
            }
        }
        private static byte[] _key;

        public static byte[] IV = new byte[]{0x43, 0x72, 0x6e, 0x6d, 0x54, 0x4d, 0x65,
                                      0x94, 0x16, 0x32, 0x44, 0x84, 0x7e, 0x18,
                                      0x64, 0x76};

        public string GenerateHash(object obj)
        {
            byte[] hashValue;
            MurmurHash3 mHash = new MurmurHash3();
            string output = JsonConvert.SerializeObject(obj);
            hashValue = mHash.ComputeHash(System.Text.Encoding.UTF8.GetBytes(output));
            return Convert.ToBase64String(Encrypt(hashValue));
        }

        private static byte[] GetKey()
        {
            int length = 24;
            var val = System.Configuration.ConfigurationManager.AppSettings["SecureHashKey"];
            val = !string.IsNullOrEmpty(val) ? val : "@f1ydubai.c0m_EyHash+va1";
            val = val.Length > length ? val.Substring(0, length) : val.PadLeft(length);
            string txt = System.Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(val));
            return System.Convert.FromBase64String(txt);
        }

        public bool ValidateHash(object obj, string hashString)
        {
            byte[] compareHashValue = Decrypt(Convert.FromBase64String(GenerateHash(obj)));
            byte[] hashValue = Decrypt(Convert.FromBase64String(hashString));
            bool flag = true;

            for (int i = 0; i < hashValue.Length; i++)
            {
                if (hashValue[i] != compareHashValue[i])
                {
                    flag = false;
                }
            }
            return flag;
        }

        public async Task<string> GenerateHashAsync(object obj)
        {
            byte[] hashValue;
            MurmurHash3 mHash = new MurmurHash3();
            BinaryFormatter bf = new BinaryFormatter();
            MemoryStream ms = new MemoryStream();
            bf.Serialize(ms, obj);
            hashValue = await mHash.ComputeHashAsync(new MemoryStream(ms.ToArray()));
            return Convert.ToBase64String(Encrypt(hashValue));
        }

        public async Task<bool> ValidateHashAsync(object obj, string hashString)
        {
            byte[] compareHashValue = Decrypt(Convert.FromBase64String(await GenerateHashAsync(obj)));
            byte[] hashValue = Decrypt(Convert.FromBase64String(hashString));
            bool flag = true;

            for (int i = 0; i < hashValue.Length; i++)
            {
                if (hashValue[i] != compareHashValue[i])
                {
                    flag = false;
                }
            }
            return flag;
        }

        private static byte[] Decrypt(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            alg.Padding = PaddingMode.Zeros;
            try
            {
                using (CryptoStream cs = new CryptoStream(ms,
                 alg.CreateDecryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
            }
            catch(Exception ex)
            {
                Logger.ErrorException("Hash service : Exception occured while writing in CryptoStream.", ex);
            }
            byte[] decryptedData = ms.ToArray();
            return decryptedData;
        }

        private static byte[] Encrypt(byte[] data)
        {
            MemoryStream ms = new MemoryStream();
            Rijndael alg = Rijndael.Create();
            alg.Key = Key;
            alg.IV = IV;
            alg.Padding = PaddingMode.Zeros;
            try
            {
                using (CryptoStream cs = new CryptoStream(ms,
                alg.CreateEncryptor(), CryptoStreamMode.Write))
                {
                    cs.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                Logger.ErrorException("Hash service : Exception occured while writing in CryptoStream.", ex);
            }
            byte[] encryptedData = ms.ToArray();
            return encryptedData;
        }
    }
}
