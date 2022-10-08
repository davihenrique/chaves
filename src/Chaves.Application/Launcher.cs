using System.Xml;
using System.Data;
using System.ComponentModel;
using System.Xml.Linq;
using Chaves.Application.Helpers;
using Chaves.Application.Screens;
using Chaves.Application.Read;

namespace Chaves.Application
{
    public static class Launcher
    {
        public static void Executar(string locate)
        {
            var locateXml = new Locate("XmlFiles/" + locate + ".xml");

            Screen.TelaInicio(locateXml);

            var press = ReadTerminal.Read();

            if (Press.PesquisarKey(locateXml, press))
                Console.WriteLine("PESQUISAR");
            else if (Press.CadrastarKey(locateXml, press))
                Console.WriteLine("Cadrastar");
            else if (Press.ImportarKey(locateXml, press))
                Console.WriteLine("Import");
        }
    }
}
