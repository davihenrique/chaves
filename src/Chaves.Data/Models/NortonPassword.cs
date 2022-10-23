using System;
using CsvHelper.Configuration.Attributes;

namespace Chaves.Data.Models
{
    public class NortonPassword : IEquatable<NortonPassword>
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

        public bool Equals(NortonPassword other)
        {
            return other.Username != Username
                && other.Password != Password
                && other.Title != Title;
        }

        public override int GetHashCode()
        {
            var hasUsername = Username is null ? 0 : Username.GetHashCode();
            var hasPassword = Password is null ? 0 : Password.GetHashCode();
            var hasTitle = Title is null ? 0 : Title.GetHashCode();

            return hasUsername ^ hasPassword ^ hasTitle;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as NortonPassword);
        }
    }
}
