using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Ey.Common
{
    public static class XmlUtility
    {
        public static XmlNode GetFirstNodeByName(XmlNode parentNode, string nodeName)
        {
            if (parentNode == null)
                throw new ArgumentNullException("parentNode");
            foreach (XmlNode xmlNode in parentNode.ChildNodes)
            {
                if (xmlNode.Name == nodeName)
                    return xmlNode;
            }
            return (XmlNode)null;
        }

        public static Collection<XmlNode> GetNodeByName(XmlNode parentNode, string nodeName)
        {
            if (parentNode == null)
                throw new ArgumentNullException("parentNode");
            Collection<XmlNode> collection = new Collection<XmlNode>();
            foreach (XmlNode xmlNode in parentNode.ChildNodes)
            {
                if (xmlNode.Name == nodeName)
                    collection.Add(xmlNode);
            }
            return collection;
        }

        public static XmlAttribute GetAttributeByName(XmlNode parentNode, string attributeName)
        {
            if (parentNode == null)
                throw new ArgumentNullException("parentNode");
            foreach (XmlAttribute xmlAttribute in (XmlNamedNodeMap)parentNode.Attributes)
            {
                if (xmlAttribute.Name == attributeName)
                    return xmlAttribute;
            }
            return (XmlAttribute)null;
        }

        public static XmlDocument Serialize(Type type, object source)
        {
            XmlDocument xmlDocument = new XmlDocument();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                new XmlSerializer(type).Serialize((Stream)memoryStream, source);
                memoryStream.Position = 0L;
                xmlDocument.Load((Stream)memoryStream);
            }
            return xmlDocument;
        }

        public static object Deserialize(Type type, string xml)
        {
            using (StringReader stringReader = new StringReader(xml))
                return new XmlSerializer(type).Deserialize((TextReader)stringReader);
        }


        public static string Serialize<T>(this T value)
        {
            if (value == null)
            {
                return string.Empty;
            }
            try
            {
                var xmlserializer = new XmlSerializer(typeof(T));
                var stringWriter = new StringWriter();
                using (var writer = XmlWriter.Create(stringWriter))
                {
                    xmlserializer.Serialize(writer, value);
                    return stringWriter.ToString();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred", ex);
            }
        }

    }
}
