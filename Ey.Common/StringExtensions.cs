using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ey.Common.StringExtensions
{
    public static class Encoders
    {
        public static byte[] StringToByteArray(this string input)
        {
            return Encoding.UTF8.GetBytes(input);
        }

        public static byte[] ToUtf8ByteArray(this string input)
        {
            return Encoders.StringToByteArray(input);
        }

        public static byte[] ToUtf32ByteArray(this string input)
        {
            return Encoding.UTF32.GetBytes(input);
        }

        public static byte[] ToUtf7ByteArray(this string input)
        {
            return Encoding.UTF7.GetBytes(input);
        }

        public static byte[] ToBigEndianUnicodeByteArray(this string input)
        {
            return Encoding.BigEndianUnicode.GetBytes(input);
        }

        public static byte[] ToUnicodeByteArray(this string input)
        {
            return Encoding.Unicode.GetBytes(input);
        }

        public static byte[] ToASCIIByteArray(this string input)
        {
            return Encoding.ASCII.GetBytes(input);
        }
    }
    public static class Transformation
    {
        public static string MakeUrlFriendly(this string value)
        {
            value = value.Trim().ToLowerInvariant();
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char ch in value)
            {
                switch (ch)
                {
                    case ' ':
                    case '-':
                        stringBuilder.Append('-');
                        break;
                    case 'a':
                    case 'b':
                    case 'c':
                    case 'd':
                    case 'e':
                    case 'f':
                    case 'g':
                    case 'h':
                    case 'i':
                    case 'j':
                    case 'k':
                    case 'l':
                    case 'm':
                    case 'n':
                    case 'o':
                    case 'p':
                    case 'q':
                    case 'r':
                    case 's':
                    case 't':
                    case 'u':
                    case 'v':
                    case 'w':
                    case 'x':
                    case 'y':
                    case 'z':
                        stringBuilder.Append(ch);
                        break;
                }
            }
            return stringBuilder.ToString().Trim('-');
        }

        public static string StripCrLf(this string value)
        {
            return value.Replace("\n", string.Empty).Replace("\r", string.Empty);
        }

        public static string JavascriptEncode(this string value)
        {
            return value.Replace("\r", string.Empty).Replace("\n", "\\n").Replace("'", "\\'");
        }

        public static string Truncate(this string value, int length)
        {
            if (string.IsNullOrEmpty(value) || value.Length <= length)
                return value;
            return value.Substring(0, length);
        }

        public static string TruncateWithThreeDots(this string value, int length)
        {
            return Transformation.Truncate(value, length) + "...";
        }

        public static string TruncateWholeWord(this string value, int length, string postString = "...")
        {
            value = value.Replace("\n", " ").Replace("\r", " ").Replace("\t", " ");
            if (value.Length <= length)
                return value;
            StringBuilder stringBuilder = new StringBuilder();
            string str1 = value;
            char[] chArray = new char[1]
            {
        ' '
            };
            foreach (string str2 in Enumerable.ToArray<string>(Enumerable.Where<string>((IEnumerable<string>)str1.Split(chArray), (Func<string, bool>)(x => !string.IsNullOrWhiteSpace(x)))))
            {
                if (stringBuilder.Length + str2.Length > length)
                    return (string)(object)stringBuilder + (object)postString;
                if (stringBuilder.Length == 0)
                    stringBuilder.Append(str2);
                else
                    stringBuilder.Append(" " + str2);
            }
            return (string)(object)stringBuilder + (object)postString;
        }

        public static string FilterSpam(this string value)
        {
            if (string.IsNullOrEmpty(value))
                return value;
            return value.Replace("http://", string.Empty).Replace("<", string.Empty).Replace(">", string.Empty).Replace("@", string.Empty).Replace("/", string.Empty).Replace("\"", string.Empty);
        }

        public static string StripXmlTags(this string xml)
        {
            StringBuilder stringBuilder = new StringBuilder(xml.Length);
            int num = 0;
            foreach (char ch in xml)
            {
                switch (ch)
                {
                    case '<':
                        ++num;
                        break;
                    case '>':
                        --num;
                        if (num < 0)
                        {
                            num = 0;
                            break;
                        }
                        break;
                    default:
                        if (num == 0)
                        {
                            stringBuilder.Append(ch);
                            break;
                        }
                        break;
                }
            }
            return stringBuilder.ToString();
        }

        public static string TrimStartString(this string input, string toTrim)
        {
            if (!input.StartsWith(toTrim))
                return input;
            return input.Substring(toTrim.Length, input.Length - toTrim.Length);
        }

        public static bool HasImageExtension(this string filename)
        {
            string extension = Path.GetExtension(filename).ToLowerInvariant().TrimStart('.');
            return Enumerable.Any<string>((IEnumerable<string>)new List<string>()
      {
        "png",
        "jpg",
        "jpeg",
        "gif"
      }, (Func<string, bool>)(x => x.ToLowerInvariant() == extension));
        }

        public static bool HasDocumentExtension(this string filename)
        {
            string extension = Path.GetExtension(filename).ToLowerInvariant().TrimStart('.');
            return Enumerable.Any<string>((IEnumerable<string>)new List<string>()
      {
        "pdf",
        "xls",
        "doc",
        "xlsx",
        "docx",
        "txt",
        "zip",
        "rar"
      }, (Func<string, bool>)(x => x.ToLowerInvariant() == extension));
        }

        public static bool HasFlashExtension(this string filename)
        {
            string extension = Path.GetExtension(filename).ToLowerInvariant().TrimStart('.');
            return Enumerable.Any<string>((IEnumerable<string>)new List<string>()
      {
        "swf"
      }, (Func<string, bool>)(x => x.ToLowerInvariant() == extension));
        }
    }
}
