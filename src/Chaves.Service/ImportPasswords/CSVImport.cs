using System.Collections.Generic;
using System.Linq;
using AutoMapper;
using Chaves.Data.Enums;
using Chaves.Data.Models;
using Chaves.Service.Dto;
using Chaves.Service.Enums;
using Chaves.Service.Helpers;
using Chaves.Service.ImportPasswords.Perfil;
using Chaves.Service.Returns;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {

        public static ImportPassServiceReturn CSVImport(SourcePath source)
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile<ImportMapperPerfil>();
            });

            var records = Enumerable.Empty<object>();

            records = SwitchServicesSources.Verify(source) switch
            {
                ServicesSources.Google => GetPassGoogleChrome(source),
                ServicesSources.Norton => GetPassNorton(source),
                _ => null,
            };

            if (records is null)
                return new ImportPassServiceReturn { StatusSource = StatusSource.Fail };

            var import = config.CreateMapper().Map<List<Password>>(records.ToList());

            return new ImportPassServiceReturn { StatusSource = StatusSource.Success, Passwords = import };
        }
    }
}
