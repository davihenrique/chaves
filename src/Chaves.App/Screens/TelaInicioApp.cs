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

        internal static void TelaImport(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxt(locate, "/Locate/SrcFile");
        }

        internal static void TelaResultFalha(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxtN(locate, "/Locate/FailScream");
        }

        internal static void TelaResultSucess(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxtN(locate, "/Locate/SuccessScreen");
        }

        internal static void TelaResultNoOne(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxtN(locate, "/Locate/NoOneScreen");
        }
    }
}
