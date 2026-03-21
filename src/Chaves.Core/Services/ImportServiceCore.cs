using System.Linq;
using Chaves.Core.Enums;
using Chaves.Core.ViewModel;
using Chaves.Service.Enums;
using Chaves.Service.ImportPasswords;
using Chaves.Service.RecordPasswords;
using Chaves.Service.Returns;

namespace Chaves.Core.Services
{
    public static class ImportServiceCore
    {
        public static ImportServiceCoreResponse Import(string src)
        {
            var import = ImportPassService.Execute(src);

            if (import.StatusSource == StatusSource.Fail)
                return new ImportServiceCoreResponse { Count = 0, Msg = ImporServiceSatus.Fail };

            if (!import.Passwords.Any())
                return new ImportServiceCoreResponse { Count = 0, Msg = ImporServiceSatus.NoOne };

            return Record(import);
        }

        private static ImportServiceCoreResponse Record(ImportPassServiceReturn pass)
        {
            var passwords = pass.Passwords.ToList();
            RecordPasswordsService.Record(passwords);
            return new ImportServiceCoreResponse { Count = passwords.Count, Msg = ImporServiceSatus.Sucess };
        }
    }
}
