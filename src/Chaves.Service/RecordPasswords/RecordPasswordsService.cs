using System.Collections.Generic;
using Chaves.Data.Models;

namespace Chaves.Service.RecordPasswords
{
    internal static partial class RecordPasswordsService
    {
        public static bool Record(List<Password> passwords)
        {
            CheckFolderChaves();
            ExistFile();

            return true;
        }
    }
}
