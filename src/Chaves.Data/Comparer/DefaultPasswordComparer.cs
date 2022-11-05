using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Chaves.Data.Models;

namespace Chaves.Data.Comparer
{
    public class DefaultPasswordComparer : IEqualityComparer<Password>
    {
        public bool Equals(Password x, Password y)
        {
            if (x.Service.Equals(y.Service)
                && x.User.Equals(y.User)
                && x.Pass.Equals(y.Pass))
                return true;

            return false;
        }

        public int GetHashCode([DisallowNull] Password obj)
        {
            var hCode = obj.Service.GetHashCode() ^ obj.User.GetHashCode() ^ obj.Pass.GetHashCode();
            return hCode.GetHashCode();
        }
    }
}
