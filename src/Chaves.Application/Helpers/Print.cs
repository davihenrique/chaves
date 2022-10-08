namespace Chaves.Application.Helpers
{
    internal static class Print
    {
        public static void PrintTxtN(Locate locate, string xmlTag)
        {
            System.Console.WriteLine(locate.LocateText(xmlTag));
        }
        public static void PrintTxt(Locate locate, string xmlTag)
        {
            System.Console.Write(locate.LocateText(xmlTag));
        }
        public static void QubraLinha()
        {
            Console.WriteLine();
        }
    }
}
