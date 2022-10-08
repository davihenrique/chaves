using Chaves.Application.Helpers;
using Chaves.Application.Screens;

namespace Chaves.Application
{
    public static class Launcher
    {
        public static void Executar(string locate)
        {
            var locateXml = new Locate("XmlFiles/" + locate + ".xml");

            Screen.TelaInicio(locateXml);

            var x = Console.ReadLine();

            if (Press.PesquisarKey(locateXml, x))
            {
                Console.WriteLine("PESQUISAR");
            }
            else if (Press.CadrastarKey(locateXml, x))
            {
                Console.WriteLine("Cadrastar");
            }
            else if (Press.ImportarKey(locateXml, x))
            {
                Console.WriteLine("Import");
            }
        }
    }
}
