using Chaves.App.Helpers;
using Chaves.App.Read;
using Chaves.App.Screens;
using Chaves.Core.Services;
using Chaves.Core.ViewModel;
using Chaves.Core.ViewModel.Enums;

namespace Chaves.App.Service
{
    public static class ImportServiceApp
    {
        public static void Execute(Locate locateXml)
        {
            ImportDetailsViewModelCore result = new();

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
