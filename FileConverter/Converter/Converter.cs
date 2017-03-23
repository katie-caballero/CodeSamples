using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;


namespace ConvertXMLJSON
{
    /// <summary>
    /// Convert XML to JSON and vice versa
    /// </summary>
    public static class Converter
    {
        /// <summary>
        /// converts xml string to json string
        /// </summary>
        /// <param name="xml">xml data as string</param>
        /// <returns>json data as string</returns>
        public static string ConvertToJson(string xml)
        {
            XmlDocument doc = new XmlDocument();
            doc.LoadXml(xml);

            //convert xml to json
            string rawJsonText = JsonConvert.SerializeXmlNode(doc.DocumentElement, Formatting.Indented);
                       
            return rawJsonText;
        }

        public static XmlDocument ConvertToXML(string json)
        {
            //convert json to xml
            XmlDocument xmlNode = JsonConvert.DeserializeXmlNode(json);
                        
            return xmlNode;
        }

        /// <summary>
        /// run converter asynchronously 
        /// </summary>
        /// <param name="xml"></param>
        /// <returns></returns>
        public static async Task<string> ConvertToJsonAsync(string xml)
        {
            return await Task<string>.Factory.StartNew(() => ConvertToJson(xml));
        }
    }
}
