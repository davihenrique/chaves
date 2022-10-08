// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Chaves.Application.Helpers;

namespace Chaves.Application.Screens
{
    internal static partial class Screen
    {
        public static void TelaInicio(Locate locate)
        {
            Print.PrintTxtN(locate, "/Locate/Logo");
            Print.PrintTxtN(locate, "/Locate/MsgInicial");
            Print.PrintTxt(locate, "/Locate/Opcoes/Exibir");
        }
    }
}
