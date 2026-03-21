using Chaves.App.Helpers;

namespace Chaves.App.Screens
{
    internal static partial class Press
    {
        public static bool PesquisarKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            return key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Pesquisar", locate.GetXml()));
        }

        public static bool CadastrarKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            return key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Cadastrar", locate.GetXml()));
        }

        public static bool ImportarKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            return key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Importar", locate.GetXml()));
        }

        public static bool SairKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            return key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Sair", locate.GetXml()));
        }
    }
}
