// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Chaves.Application.Helpers;

namespace Chaves.Application.Screens
{
    internal static partial class Press
    {
        public static bool PesquisarKey(Locate locate, string key)
        {
            if (key is null)
                return false;

            if (key.ToUpper().Equals(locate.LocateText("/Locate/Opcoes/Pesquisar")))
                return true;

            return false;
        }

        public static bool CadrastarKey(Locate locate, string key)
        {
            if (key is null)
                return false;

            if (key.ToUpper().Equals(locate.LocateText("/Locate/Opcoes/Cadrastar")))
                return true;

            return false;
        }

        public static bool ImportarKey(Locate locate, string key)
        {
            if (key is null)
                return false;

            if (key.ToUpper().Equals(locate.LocateText("/Locate/Opcoes/Importar")))
                return true;

            return false;
        }
    }
}
