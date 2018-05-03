using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace flydubai.Common.Helpers
{
    public static class NCompressor
    {
        private static int MAX_BUFFER_SIZE = 1024;

        private static byte[] Compress(byte[] byteArray )
        {
            MemoryStream inputMemoryStream = new MemoryStream(byteArray);
            MemoryStream outputMemoryStream = new MemoryStream(); ;
            byte[] compressedBuffer = null;

            using (GZipStream outputGZipStream = new GZipStream(outputMemoryStream, CompressionMode.Compress))
            {
                byte[] buffer = new byte[MAX_BUFFER_SIZE];
                int bytesRead = -1;

                while ((bytesRead = inputMemoryStream.Read(buffer, 0, MAX_BUFFER_SIZE)) > 0)
                {
                    outputGZipStream.Write(buffer, 0, bytesRead);
                }
            }
            compressedBuffer = outputMemoryStream.ToArray();

            if (outputMemoryStream != null) { outputMemoryStream.Close(); }
            if (inputMemoryStream != null) { inputMemoryStream.Close(); }

            return compressedBuffer;
        }

        public static string CompressToBase64String(string data)
        {
            return Convert.ToBase64String(Compress(Encoding.UTF8.GetBytes(data)));
        }
        public static byte[] CompressToBase64Bytes(string data)
        {
            return Compress(Encoding.UTF8.GetBytes(data));
        }
        private static byte[] Decompress(byte[] byteArray)
        {
            MemoryStream inputMemoryStream = new MemoryStream(byteArray);
            MemoryStream outputMemoryStream = new MemoryStream();
            byte[] decompressedBuffer = null;

            using (GZipStream inputGZipStream = new GZipStream(inputMemoryStream, CompressionMode.Decompress))
            {
                byte[] buffer = new byte[MAX_BUFFER_SIZE];
                int bytesRead = -1;

                while ((bytesRead = inputGZipStream.Read(buffer, 0, MAX_BUFFER_SIZE)) > 0)
                {
                    outputMemoryStream.Write(buffer, 0, bytesRead);
                }
            }

            decompressedBuffer = outputMemoryStream.ToArray();

            if (inputMemoryStream != null) { inputMemoryStream.Close(); }
            if (outputMemoryStream != null) { outputMemoryStream.Close(); }

            return decompressedBuffer;
        }

        public static string DecompressFromBase64String(string base64String)
        {
            return Encoding.UTF8.GetString(Decompress(Convert.FromBase64String(base64String)));
        }
        public static string DecompressFromBase64Bytes(byte[] base64bytes)
        {
            return Encoding.UTF8.GetString(Decompress(base64bytes));
        }
    }
}
