﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using Chaves.Data.Comparer;
using Chaves.Data.Models;
using Chaves.Service.Dto;
using CsvHelper;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {
        public static IEnumerable<NortonPassword> GetPassNorton(SourcePath source)
        {
            try
            {
                var reader = new StreamReader(source.Src);
                var csv = new CsvReader(reader, CultureInfo.InvariantCulture);
                var pass = csv.GetRecords<NortonPassword>().AsEnumerable().Distinct(new NortonPasswordComparer()).ToList();
                csv.Dispose();
                return pass;
            }
            catch (Exception)
            {
                return Enumerable.Empty<NortonPassword>();
            }
        }
    }
}
