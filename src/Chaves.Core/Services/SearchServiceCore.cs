using System.Collections.Generic;
using System.Linq;
using Chaves.Core.Returns;
using Chaves.Service.Crypto;
using Chaves.Service.RecordPasswords;

namespace Chaves.Core.Services
{
    public static class SearchServiceCore
    {
        public static IEnumerable<PasswordResult> GetAll(string key)
        {
            return RecordPasswordsService.GetPasswords().Select(p => new PasswordResult
            {
                Service = p.Service,
                User = p.User,
                Pass = PasswordCrypto.TryDecrypt(p.Pass, key)
            });
        }
    }
}
