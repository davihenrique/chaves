using System.Xml;

namespace Chaves.App.Helpers
{
    public class Locate
    {
        public string? LocateName { get; set; }
        public XmlDocument Xml { get; set; }

        public Locate(string locateName)
        {
            Xml = new XmlDocument();
            Xml.Load(locateName);
        }

        public XmlDocument GetXml() => Xml;

        public static string LocateText(string tag, XmlDocument xml)
        {
            try
            {
                var retorno = xml.DocumentElement?.SelectSingleNode(tag)?.InnerText;

                if (retorno is null)
                    return "ERROR EMPTY XML";

                return retorno;
            }
            catch (NullReferenceException)
            {
                return "ERROR XML";
            }
        }
    }
}
