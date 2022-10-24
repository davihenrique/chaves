using System.Collections.Generic;
using System.Linq;
using Chaves.Core.ViewModel;
using Chaves.Core.ViewModel.Enums;
using Chaves.Data.Models;
using Chaves.Service.ImportPasswords;

namespace Chaves.Core.Services
{
    public static class ImportServiceCore
    {

        public static ImportDetailsViewModelCore Import(string src)
        {
            var passwords = ImportPassService.Execute(src);

            if (passwords is null)
                return new ImportDetailsViewModelCore { Count = 0, Msg = ImporServiceSatus.Fail };

            if (!passwords.Any())
                return new ImportDetailsViewModelCore { Count = 0, Msg = ImporServiceSatus.NoOne };

            return Record(passwords);

        }

        public static ImportDetailsViewModelCore Record(IEnumerable<Password> passwords)
        {
            return new ImportDetailsViewModelCore { Count = passwords.Count(), Msg = ImporServiceSatus.Sucess };
        }
    }
}
