using System.Collections.Generic;
using Chaves.Data.Models;
using Chaves.Service.ImportPasswords;

namespace Chaves.Service.RecordPasswords
{


    internal static partial class RecordPasswordsService
    {
        public static bool Record(IEnumerable<Password> passwords)
        {

            var passwordStored = GetPasswords();

            CheckFolderChaves();
            ExistFile();



            RecordCsv(passwords);

            return true;
        }

        private static IEnumerable<Password> GetPasswords()
        {
            var file = "c:\\chaves\\pass.csv";

            var passwords = ImportPassService.ExecuteWithReturnPass(file);

            return passwords;
        }
    }
}
