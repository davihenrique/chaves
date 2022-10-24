using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using Chaves.Data.Models;

namespace Chaves.Data.Comparer
{
    public class NortonPasswordComparer : IEqualityComparer<NortonPassword>
    {
        public bool Equals(NortonPassword x, NortonPassword y)
        {
            if (x.Username.Equals(y.Username)
                && x.Password.Equals(y.Password)
                && x.Title.Equals(y.Title))
                return true;

            return false;
        }

        public int GetHashCode([DisallowNull] NortonPassword obj)
        {
            var hCode = obj.Username.GetHashCode() ^ obj.Password.GetHashCode() ^ obj.Title.GetHashCode();
            return hCode.GetHashCode();
        }
    }
}
