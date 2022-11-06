using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Chaves.Data.Comparer;
using Chaves.Data.Models;
using Chaves.Service.Dto;
using CsvHelper;

namespace Chaves.Service.ImportPasswords.ImportCSV
{
    public static partial class ImportServiceCsv
    {
        public static IEnumerable<GooglePassword> GetPassGoogleChrome(SourcePath source)
        {
            try
            {
                var reader = new StreamReader(source.Src);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                var pass = csv.GetRecords<GooglePassword>().AsEnumerable().Distinct(new GooglePasswordComparer());
                csv.Dispose();

                return pass;
            }
            catch (Exception)
            {
                return Enumerable.Empty<GooglePassword>();
            }
        }
    }
}
