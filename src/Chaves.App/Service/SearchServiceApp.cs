using System.Linq;
using Chaves.App.Helpers;
using Chaves.App.Read;
using Chaves.App.Screens;
using Chaves.Core.Services;

namespace Chaves.App.Service
{
    public static class SearchServiceApp
    {
        public static void Execute(Locate locateXml)
        {
            Print.PrintTxt(locateXml, "/Locate/Pesquisar/PalavraChave");
            var key = ReadTerminalReadApp.Read() ?? string.Empty;

            var passwords = SearchServiceCore.GetAll(key).ToList();
            Screen.TelaResultPesquisar(locateXml, passwords);
        }
    }
}
