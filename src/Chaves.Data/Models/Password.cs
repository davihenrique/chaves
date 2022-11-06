using System;

namespace Chaves.Data.Models
{
    public class Password
    {
        public Guid Id { get; set; }
        public string Service { get; set; }
        public string User { get; set; }
        public string Pass { get; set; }
    }
}
