using System.Collections.Generic;
using System.Linq;
using Chaves.Data.Enums;
using Chaves.Data.Models;
using Chaves.Service.Dto;
using Chaves.Service.Helpers;

namespace Chaves.Service.ImportPasswords.ImportCSV
{
    public static partial class ImportServiceCsv
    {
        public static IEnumerable<Password> CSVImport(SourcePath source)
        {
            return SwitchServicesSources.Verify(source) switch
            {
                ServicesSources.Default => GetPassDefault(source),
                ServicesSources.Google => GetPassGoogleChrome(source).Select(g => new Password
                {
                    Service = g.Name,
                    User = g.Username,
                    Pass = g.Password
                }),
                ServicesSources.Norton => GetPassNorton(source).Select(n => new Password
                {
                    Service = n.Title,
                    User = n.Username,
                    Pass = n.Password
                }),
                _ => Enumerable.Empty<Password>()
            };
        }
    }
}
