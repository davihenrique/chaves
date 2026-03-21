using System;
using System.Collections.Generic;
using System.Linq;
using Chaves.App.Helpers;
using Chaves.Core.Returns;

namespace Chaves.App.Screens
{
    internal static partial class Screen
    {
        public static void TelaInicio(Locate locate)
        {
            Console.Clear();
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

        internal static void TelaResultSucess(Locate locate, int count)
        {
            Print.QubraLinha();
            Print.PrintTxt(locate, "/Locate/SuccessScreen");
            Console.WriteLine($" ({count})");
        }

        internal static void TelaResultNoOne(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxtN(locate, "/Locate/NoOneScreen");
        }

        internal static void TelaCadastrar(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxt(locate, "/Locate/Cadastrar/Servico");
        }

        internal static void TelaResultCadastrado(Locate locate)
        {
            Print.QubraLinha();
            Print.PrintTxtN(locate, "/Locate/CadastradoScreen");
        }

        internal static void TelaResultPesquisar(Locate locate, IList<PasswordResult> passwords)
        {
            Print.QubraLinha();

            if (!passwords.Any())
            {
                Print.PrintTxtN(locate, "/Locate/PesquisarVazio");
                Print.QubraLinha();
                Print.PrintTxtN(locate, "/Locate/PressEnter");
                Console.ReadLine();
                return;
            }

            var encryptedLabel = Locate.LocateText("/Locate/Encrypted", locate.GetXml());

            Console.WriteLine($"{"Servico",-30} {"Usuario",-35} {"Senha",-30}");
            Console.WriteLine(new string('-', 95));
            foreach (var p in passwords)
                Console.WriteLine($"{p.Service,-30} {p.User,-35} {(p.Pass ?? encryptedLabel),-30}");

            Print.QubraLinha();
            Print.PrintTxtN(locate, "/Locate/PressEnter");
            Console.ReadLine();
        }
    }
}
