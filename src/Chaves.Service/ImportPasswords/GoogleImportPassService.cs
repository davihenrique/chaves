using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Chaves.Data.Models;
using Chaves.Service.Dto;
using CsvHelper;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {
        public static IEnumerable<GooglePassword> GetPassGoogleChrome(SourcePath source)
        {
            try
            {
                var reader = new StreamReader(source.Src);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                return csv.GetRecords<GooglePassword>().ToList().Distinct();
            }
            catch (Exception)
            {
                return Enumerable.Empty<GooglePassword>();
            }
        }
    }
}
