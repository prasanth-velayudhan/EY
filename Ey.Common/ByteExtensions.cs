using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Common.ByteExtensions
{
    public static class Encoders
    {
        public static string ToHexString(this byte[] input)
        {
            if (input == null)
                return (string)null;
            StringBuilder stringBuilder = new StringBuilder(input.Length * 2);
            foreach (byte num in input)
                stringBuilder.Append(num.ToString("x", (IFormatProvider)CultureInfo.InvariantCulture).PadLeft(2, '0'));
            return stringBuilder.ToString();
        }

        public static string ToBase64String(this byte[] input)
        {
            return Convert.ToBase64String(input);
        }

        public static byte[] SHA256(this byte[] input)
        {
            using (HashAlgorithm hashAlgorithm = (HashAlgorithm)new SHA256Managed())
                return hashAlgorithm.ComputeHash(input);
        }

        public static byte[] SHA1(this byte[] input)
        {
            using (HashAlgorithm hashAlgorithm = (HashAlgorithm)new SHA1Managed())
                return hashAlgorithm.ComputeHash(input);
        }

        public static byte[] MD5(this byte[] input)
        {
            using (HashAlgorithm hashAlgorithm = (HashAlgorithm)new MD5CryptoServiceProvider())
                return hashAlgorithm.ComputeHash(input);
        }
    }
}
