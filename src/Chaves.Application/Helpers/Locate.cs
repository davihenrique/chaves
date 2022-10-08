using System.Xml;

namespace Chaves.Application.Helpers
{
    public class Locate
    {
        public string LocateName { get; set; }
        public XmlDocument Xml { get; set; }
        public Locate(string locateName)
        {
            Xml = new XmlDocument();
            Xml.Load(locateName);
        }

        public string LocateText(string tag)
        {
            try
            {
                return Xml.DocumentElement.SelectSingleNode(tag).InnerText;
            }
            catch (NullReferenceException)
            {
                return "ERROR XML";
            }
        }
    }
}
