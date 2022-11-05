using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Chaves.Data.Enums;
using Chaves.Data.Models;
using Chaves.Service.Dto;
using Chaves.Service.Helpers;
using Chaves.Service.ImportPasswords.Perfil;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {

        public static IEnumerable<Password> CSVImport(SourcePath source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ImportMapperPerfil>();
            });

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

            var import = config.CreateMapper().Map<List<Password>>(records.ToList());

            return import;
        }
    }
}
