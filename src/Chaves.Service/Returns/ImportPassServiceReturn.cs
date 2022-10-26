using System.Collections.Generic;
using Chaves.Data.Models;
using Chaves.Service.Enums;

namespace Chaves.Service.Returns
{
    public class ImportPassServiceReturn
    {
        public StatusSource StatusSource { get; set; }
        public IEnumerable<Password> Passwords { get; set; }
    }
}
