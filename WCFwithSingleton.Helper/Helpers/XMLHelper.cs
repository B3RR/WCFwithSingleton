using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace WCFwithSingleton.Helper.Helpers
{
    public class XMLHelper
    {
        /// <summary>
        /// Приводит Xml к читабельному виду
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static string PrettyXml(string xml)
        {
            if (!String.IsNullOrWhiteSpace(xml))
            {
                var stringBuilder = new StringBuilder();
                var element = XElement.Parse(xml);
                var settings = new XmlWriterSettings()
                {
                    OmitXmlDeclaration = true,
                    Indent = true,
                    NewLineOnAttributes = true
                };
                using (var xmlWriter = XmlWriter.Create(stringBuilder, settings))
                {
                    element.Save(xmlWriter);
                }
                return stringBuilder.ToString();
            }
            return String.Empty;
        }


        /// <summary>
        /// Конвертирует объект в String
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public static string ConvertObjectToXmlString(object obj)
        {
            if (obj != null)
            {
                using (var stringwriter = new StringWriter())
                {
                    var serializer = new XmlSerializer(obj.GetType());
                    serializer.Serialize(stringwriter, obj);
                    return stringwriter.ToString();
                }
            }
            return String.Empty;

        }


    }
}
