using System.IO;
using System.Text;
using System.Xml;

namespace PickleStudio.Core.Extensions
{
    public static class ByteArrayExtensions
    {
        private static readonly string _byteOrderMarkUtf8 = Encoding.UTF8.GetString(Encoding.UTF8.GetPreamble());

        public static XmlReader ToXmlReader(this byte[] bytes)
        {
            string xml = UTF8Encoding.UTF8.GetString(bytes);
            if (xml.StartsWith(_byteOrderMarkUtf8)) xml = xml.Remove(0, _byteOrderMarkUtf8.Length); // this is bullshit!

            var xmlReader = XmlReader.Create(new StringReader(xml), new XmlReaderSettings { CloseInput = true });

            return xmlReader;
        }
    }
}
