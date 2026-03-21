using Chaves.App.Helpers;
using Chaves.App.Read;
using Chaves.App.Screens;
using Chaves.Core.Enums;
using Chaves.Core.Services;
using Chaves.Core.ViewModel;

namespace Chaves.App.Service
{
    public static class ImportServiceApp
    {
        public static void Execute(Locate locateXml)
        {
            ImportServiceCoreResponse result = new();

            Screen.TelaImport(locateXml);

            var readTerminal = ReadTerminalReadApp.Read();

            if (!string.IsNullOrEmpty(readTerminal))
                result = ImportServiceCore.Import(readTerminal);

            if (result.Msg == ImporServiceSatus.Sucess)
                Screen.TelaResultSucess(locateXml);

            if (result.Msg == ImporServiceSatus.Fail)
                Screen.TelaResultFalha(locateXml);

            if (result.Msg == ImporServiceSatus.NoOne)
                Screen.TelaResultNoOne(locateXml);

        }
    }
}
