using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Chaves.Data.Models;
using CsvHelper;
using CsvHelper.Configuration;

namespace Chaves.Service.RecordPasswords
{
    public static partial class RecordPasswordsService
    {
        private const string FolderPath = @"c:\chaves";
        private const string FilePath = @"c:\chaves\pass.csv";

        public static bool CheckFolderChaves()
        {
            if (!Directory.Exists(FolderPath))
                Directory.CreateDirectory(FolderPath);

            return true;
        }

        public static bool ExistFile()
        {
            if (File.Exists(FilePath))
                return true;

            var writer = new StreamWriter(FilePath);
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            csv.WriteHeader<Password>();
            csv.NextRecord();
            csv.Flush();
            csv.Dispose();

            return true;
        }

        public static void RecordCsv(IEnumerable<Password> passwords)
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false,
            };

            var stream = File.Open(FilePath, FileMode.Append);
            var writer = new StreamWriter(stream);
            var csv = new CsvWriter(writer, config);

            foreach (var p in passwords)
                p.Id = Guid.NewGuid();

            csv.WriteRecords(passwords);
            csv.Flush();
            csv.Dispose();
        }
    }
}
