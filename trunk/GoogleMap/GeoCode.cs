using System;
using System.Text;
using System.Net;
using System.IO;
using System.Xml;
using System.Configuration;

namespace GoogleMap
{
    public class GeoCode
    {

        public GeoCode()
        {
        }
        public GeoCode(string Address)
        {
            string requerstUrl = string.Format(@"http://maps.google.com/maps/geo?q={0}&output=xml&oe=utf8\
&sensor=false&key={1}", Address, ConfigurationSettings.AppSettings["GoogleApiKey"]);


            HttpWebRequest webRequest;
            WebResponse webResponse;
            Encoding encoding = new UTF8Encoding();

            string postData = "This is a test that posts this string to a Web server.";
            Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            webRequest = (HttpWebRequest)HttpWebRequest.Create(requerstUrl);
            webRequest.Method = "GET";
            webRequest.Accept = "text/xml";
            webResponse = webRequest.GetResponse();
            Stream getstrem;
            getstrem = webResponse.GetResponseStream();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.Load(getstrem);
            xmldoc.Save("c://geoCode.xml");

            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmldoc.NameTable);
            nsmgr.AddNamespace("kml", "http://earth.google.com/kml/2.0");
            XmlNodeList coordinateNode = xmldoc.GetElementsByTagName("coordinates");
            string Coordinate = coordinateNode[0].InnerText;

        }
        public string[] GetLatLng(string Address)
        {
            try
            {
                string requerstUrl = string.Format(@"http://maps.google.com/maps/geo?q={0}&output=xml&oe=utf8\
&sensor=false&key={1}", Address, ConfigurationSettings.AppSettings["GoogleApiKey"]);


                HttpWebRequest webRequest;
                WebResponse webResponse;
                Encoding encoding = new UTF8Encoding();

                string postData = "This is a test that posts this string to a Web server.";
                Byte[] byteArray = Encoding.UTF8.GetBytes(postData);
                webRequest = (HttpWebRequest)HttpWebRequest.Create(requerstUrl);
                webRequest.Method = "GET";
                webRequest.Accept = "text/xml";
                webResponse = webRequest.GetResponse();
                Stream getstrem;
                getstrem = webResponse.GetResponseStream();
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(getstrem);
                xmldoc.Save("c://geoCode.xml");

                XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmldoc.NameTable);
                nsmgr.AddNamespace("kml", "http://earth.google.com/kml/2.0");
                XmlNodeList coordinateNode = xmldoc.GetElementsByTagName("coordinates");
                string Coordinate = coordinateNode[0].InnerText;

                string[] latlng = Coordinate.Split(',');
                return latlng;
            }
            catch
            {
                 return new string[0];
            }
        }


    }
}
