using System.Collections.Generic;
using System.Linq;
using Chaves.Data.Models;
using Chaves.Service.Enums;
using Chaves.Service.Helpers;
using Chaves.Service.ImportPasswords.ImportCSV;
using Chaves.Service.Returns;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {
        public static ImportPassServiceReturn Execute(string src)
        {
            var source = SourceHelper.Execute(src);

            if (!source.Valid)
                return new ImportPassServiceReturn { StatusSource = Enums.StatusSource.Fail };

            var pass = ImportServiceCSV.CSVImport(source);

            if (pass is null)
                return new ImportPassServiceReturn { StatusSource = StatusSource.Fail };

            return new ImportPassServiceReturn { StatusSource = StatusSource.Success, Passwords = pass };
        }

        public static IEnumerable<Password> ExecuteWithReturnPass(string src)
        {
            var source = SourceHelper.Execute(src);

            if (source.Valid)
                return ImportServiceCSV.CSVImport(source);

            return Enumerable.Empty<Password>();
        }
    }
}
