using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace BusinessLogic
{
    public class XMLHelper
    {
        public string SerializeXML(object objdata)
        {
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());
            var data = objdata;
            Type oType = data.GetType();
            XmlSerializer serializer = new XmlSerializer(oType);
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = ' ';
            writer.Indentation = 3;
            serializer.Serialize(writer, data);
            byte[] Result = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(Result, 0, (int)ms.Length);
            string XmlResultString = Encoding.UTF8.GetString(Result, 0, (int)ms.Length);
            return XmlResultString;
        }
        public XElement Serialize(object objdata)
        {
            MemoryStream ms = new MemoryStream();
            XmlTextWriter writer = new XmlTextWriter(ms, new UTF8Encoding());
            var data = objdata;
            Type oType = data.GetType();
            XmlSerializer serializer = new XmlSerializer(oType);
            writer.Formatting = Formatting.Indented;
            writer.IndentChar = ' ';
            writer.Indentation = 3;
            serializer.Serialize(writer, data);
            byte[] Result = new byte[ms.Length];
            ms.Position = 0;
            ms.Read(Result, 0, (int)ms.Length);
            string XmlResultString = Encoding.UTF8.GetString(Result, 0, (int)ms.Length);
            XDocument xmlDoc = XDocument.Parse(XmlResultString);
            return xmlDoc.Root;
        }
        public XElement GetXElementFromString(string XmlString, string xElementName)
        {
            XDocument xmlDoc = XDocument.Parse(XmlString);
            XElement data = xmlDoc.Element(xElementName);
            return data;
        }
        public object Deserialize(XElement xml, object _object)
        {
            
            XmlSerializer ser = new XmlSerializer(_object.GetType());
            StringReader strreader = new StringReader(xml.ToString());
            XmlTextReader xmlread = new XmlTextReader(strreader);
            _object =ser.Deserialize(xmlread);
            return _object;
                
        }
    }
}
