using Chaves.Service.Helpers;
using Chaves.Service.Returns;

namespace Chaves.Service.ImportPasswords
{
    public static partial class ImportPassService
    {
        public static ImportPassServiceReturn Execute(string src)
        {

            var source = SourceHelper.Execute(src);

            if (source.Valid)
                return CSVImport(source);

            return new ImportPassServiceReturn { StatusSource = Enums.StatusSource.Fail };
        }

    }
}
