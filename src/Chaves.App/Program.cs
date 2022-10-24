using System.Globalization;

namespace Chaves.App
{
    internal static class Program
    {
        static void Main()
        {
            if (CultureInfo.CurrentUICulture.Name.Equals("pt-BR")
                || CultureInfo.CurrentUICulture.Name.Equals("en-US"))
                Launcher.Executar(CultureInfo.CurrentUICulture.Name);
            else
                Launcher.Executar("en-US");
        }
    }
}
