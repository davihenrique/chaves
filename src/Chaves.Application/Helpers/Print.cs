namespace Chaves.Application.Helpers
{
    internal static class Print
    {
        public static void PrintTxtN(Locate locate, string xmlTag)
        {
            System.Console.WriteLine(Locate.LocateText(xmlTag, locate.GetXml()));
        }
        public static void PrintTxt(Locate locate, string xmlTag)
        {
            System.Console.Write(Locate.LocateText(xmlTag, locate.GetXml()));
        }
        public static void QubraLinha()
        {
            Console.WriteLine();
        }
    }
}
