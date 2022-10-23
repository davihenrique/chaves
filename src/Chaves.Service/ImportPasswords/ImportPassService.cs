using System.Collections.Generic;
using Chaves.Data.Models;
using Chaves.Service.Helpers;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {

        public static IEnumerable<Password> Execute(string src)
        {

            var source = SourceHelper.Execute(src);

            if (source.Valid)
                return GetPass(source);

            return null;
        }

    }
}
