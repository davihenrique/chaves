using System;
using Chaves.Service.Dto;

namespace Chaves.Service.Helpers
{
    internal static class SourceHelper
    {
        internal static SourcePath Execute(string src)
        {
            var sourcePath = new SourcePath { Valid = false };

            if (src is null)
                return sourcePath;

            if (src[Math.Max(0, src.Length - 5)..].Equals(".csv\"")
                || src[Math.Max(0, src.Length - 4)..].Equals(".csv"))
            {
                sourcePath.Src = src; // FIXME Validar Regra
                sourcePath.Valid = true;
            }

            return sourcePath;
        }
    }
}
