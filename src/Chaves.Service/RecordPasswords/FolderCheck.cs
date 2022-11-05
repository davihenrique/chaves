using System.IO;

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

            return true;
        }

    }
}
