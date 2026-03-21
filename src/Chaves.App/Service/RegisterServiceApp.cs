using Chaves.App.Helpers;
using Chaves.App.Read;
using Chaves.App.Screens;
using Chaves.Core.Services;

namespace Chaves.App.Service
{
    public static class RegisterServiceApp
    {
        public static void Execute(Locate locateXml)
        {
            Screen.TelaCadastrar(locateXml);
            var service = ReadTerminalReadApp.Read();

            Print.PrintTxt(locateXml, "/Locate/Cadastrar/Usuario");
            var user = ReadTerminalReadApp.Read();

            Print.PrintTxt(locateXml, "/Locate/Cadastrar/Senha");
            var pass = ReadTerminalReadApp.Read();

            Print.PrintTxt(locateXml, "/Locate/Cadastrar/PalavraChave");
            var key = ReadTerminalReadApp.Read();

            if (string.IsNullOrWhiteSpace(service) || string.IsNullOrWhiteSpace(user)
                || string.IsNullOrWhiteSpace(pass) || string.IsNullOrWhiteSpace(key))
                return;

            RegisterServiceCore.Register(service, user, pass, key);
            Screen.TelaResultCadastrado(locateXml);
            System.Console.ReadLine();
        }
    }
}
