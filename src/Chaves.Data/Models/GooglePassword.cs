using System;
using CsvHelper.Configuration.Attributes;

namespace Chaves.Data.Models
{
    public class GooglePassword : IEquatable<GooglePassword>
    {
        [Name("name")]
        public string Name { get; set; }

        [Name("url")]
        public string Url { get; set; }

        [Name("username")]
        public string Username { get; set; }

        [Name("password")]
        public string Password { get; set; }

        public bool Equals(GooglePassword other)
        {
            if (Name.Equals(other.Name)
                && Username.Equals(other.Username)
                && Password.Equals(other.Password))
                return true;
            return false;
        }

        public override int GetHashCode()
        {
            var hasName = Name is null ? 0 : Name.GetHashCode();
            var hasUsername = Username is null ? 0 : Username.GetHashCode();
            var hasPassword = Password is null ? 0 : Password.GetHashCode();

            return hasName ^ hasUsername ^ hasPassword;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as GooglePassword);
        }
    }
}
