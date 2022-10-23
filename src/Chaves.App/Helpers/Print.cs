namespace Chaves.App.Helpers
{
    internal static class Print
    {
        public static void PrintTxtN(Locate locate, string xmlTag)
        {
            Console.WriteLine(Locate.LocateText(xmlTag, locate.GetXml()));
        }
        public static void PrintTxt(Locate locate, string xmlTag)
        {
            Console.Write(Locate.LocateText(xmlTag, locate.GetXml()));
        }
        public static void QubraLinha()
        {
            Console.WriteLine();
        }
    }
}
