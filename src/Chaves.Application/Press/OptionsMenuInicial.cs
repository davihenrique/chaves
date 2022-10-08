using Chaves.Application.Helpers;

namespace Chaves.Application.Screens
{
    internal static partial class Press
    {
        public static bool PesquisarKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            if (key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Pesquisar", locate.GetXml())))
                return true;

            return false;
        }

        public static bool CadrastarKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            if (key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Cadrastar", locate.GetXml())))
                return true;

            return false;
        }

        public static bool ImportarKey(Locate locate, string? key)
        {
            if (key is null)
                return false;

            if (key.ToUpper().Equals(Locate.LocateText("/Locate/Opcoes/Importar", locate.GetXml())))
                return true;

            return false;
        }
    }
}
