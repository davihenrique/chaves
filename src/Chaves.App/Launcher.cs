using Chaves.App.Helpers;
using Chaves.App.Read;
using Chaves.App.Screens;
using Chaves.App.Service;

namespace Chaves.App
{
    public static class Launcher
    {
        public static void Executar(string locate)
        {
            var locateXml = new Locate("XmlFiles/" + locate + ".xml");

            var running = true;
            while (running)
            {
                Screen.TelaInicio(locateXml);

                var press = ReadTerminalReadApp.Read();

                if (Press.PesquisarKey(locateXml, press))
                    SearchServiceApp.Execute(locateXml);
                else if (Press.CadastrarKey(locateXml, press))
                    RegisterServiceApp.Execute(locateXml);
                else if (Press.ImportarKey(locateXml, press))
                    ImportServiceApp.Execute(locateXml);
                else if (Press.SairKey(locateXml, press))
                    running = false;
            }

            Print.PrintTxtN(locateXml, "/Locate/MsgFinal");
        }
    }
}
