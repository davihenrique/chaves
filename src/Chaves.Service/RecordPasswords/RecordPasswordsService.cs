using System.Collections.Generic;
using System.Linq;
using Chaves.Data.Models;
using Chaves.Service.ImportPasswords;

namespace Chaves.Service.RecordPasswords
{
    public static partial class RecordPasswordsService
    {
        public static bool Record(IEnumerable<Password> passwords)
        {
            CheckFolderChaves();
            ExistFile();
            RecordCsv(passwords);
            return true;
        }

        public static IEnumerable<Password> GetPasswords()
        {
            CheckFolderChaves();
            ExistFile();

            var passwords = ImportPassService.ExecuteWithReturnPass(FilePath);
            return passwords.ToList();
        }
    }
}
