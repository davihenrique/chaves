using Chaves.Data.Models;
using Chaves.Service.Crypto;
using Chaves.Service.RecordPasswords;

namespace Chaves.Core.Services
{
    public static class RegisterServiceCore
    {
        public static void Register(string service, string user, string pass, string key)
        {
            var encrypted = PasswordCrypto.Encrypt(pass, key);
            var password = new Password { Service = service, User = user, Pass = encrypted };
            RecordPasswordsService.Record(new[] { password });
        }
    }
}
