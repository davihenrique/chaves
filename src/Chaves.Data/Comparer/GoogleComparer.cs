using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Chaves.Data.Models;

namespace Chaves.Data.Comparer
{
    public class GoogleComparer : IEqualityComparer<GooglePassword>
    {
        public bool Equals(GooglePassword x, GooglePassword y)
        {
            if (x.Name.Equals(y.Name)
                && x.Username.Equals(y.Username)
                && x.Password.Equals(y.Password))
                return true;

            return false;
        }

        public int GetHashCode([DisallowNull] GooglePassword obj)
        {
            var hCode = obj.Name.GetHashCode() ^ obj.Username.GetHashCode() ^ obj.Password.GetHashCode();
            return hCode.GetHashCode();
        }
    }
}
