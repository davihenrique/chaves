using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using Chaves.Data.Models;
using CsvHelper;
using CsvHelper.Configuration;

namespace Chaves.Service.RecordPasswords
{

    internal static partial class RecordPasswordsService
    {
        public static bool CheckFolderChaves()
        {
            var diretory = "c:\\chaves";
            if (!Directory.Exists(diretory))
                Directory.CreateDirectory("C:\\chaves");


            return true;
        }

        public static bool ExistFile()
        {
            var file = "c:\\chaves\\pass.csv";

            if (File.Exists(file))
                return true;

            var writer = new StreamWriter(file);
            var csv = new CsvWriter(writer, CultureInfo.InvariantCulture);
            var pass = new List<Password>();

            csv.WriteRecords(pass);
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

            var stream = File.Open("c:\\chaves\\pass.csv", FileMode.Append);
            var writer = new StreamWriter(stream);
            var csv = new CsvWriter(writer, config);


            foreach (var p in passwords)
                p.Id = new Guid();

            csv.WriteRecords(passwords);
            csv.Flush();
            csv.Dispose();
        }

    }
}
