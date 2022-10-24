using CsvHelper.Configuration.Attributes;

namespace Chaves.Data.Models
{
    public class NortonPassword
    {
        [Name("Username")]
        public string Username { get; set; }

        [Name("Password")]
        public string Password { get; set; }

        [Name("Title")]
        public string Title { get; set; }

        [Name("Login URL")]
        public string LoginURL { get; set; }

        [Name("Notes")]
        public string Notes { get; set; }
    }
}
