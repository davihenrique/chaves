using Chaves.App.Helpers;

namespace Chaves.App.Screens
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
