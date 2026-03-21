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
            var records = Enumerable.Empty<object>();

            records = SwitchServicesSources.Verify(source) switch
            {
                ServicesSources.Default => GetPassDefault(source),
                ServicesSources.Google => GetPassGoogleChrome(source),
                ServicesSources.Norton => GetPassNorton(source),
                _ => null,
            };

            if (records is null)
                return Enumerable.Empty<Password>();

            return SwitchServicesSources.Verify(source) switch
            {
                ServicesSources.Google => records.Cast<GooglePassword>().Select(g => new Password
                {
                    Service = g.Name,
                    User = g.Username,
                    Pass = g.Password
                }),
                ServicesSources.Norton => records.Cast<NortonPassword>().Select(n => new Password
                {
                    Service = n.Title,
                    User = n.Username,
                    Pass = n.Password
                }),
                _ => records.Cast<Password>()
            };
        }
    }
}
