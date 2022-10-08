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

        public XmlDocument GetXml()
        {
            return Xml;
        }

        public static string LocateText(string tag, XmlDocument xml)
        {
            try
            {
                var retorno = xml.DocumentElement?.SelectSingleNode(tag)?.InnerText;

                if (retorno is null)
                    return "ERROR XML NULO";

                return retorno;
            }
            catch (NullReferenceException)
            {
                return "ERROR XML";
            }
        }
    }
}
