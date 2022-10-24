using CsvHelper.Configuration.Attributes;

namespace Chaves.Data.Models
{
    public class GooglePassword
    {
        [Name("name")]
        public string Name { get; set; }

        [Name("url")]
        public string Url { get; set; }

        [Name("username")]
        public string Username { get; set; }

        [Name("password")]
        public string Password { get; set; }
    }
}
