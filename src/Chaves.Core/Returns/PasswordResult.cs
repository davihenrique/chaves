namespace Chaves.Core.Returns
{
    public class PasswordResult
    {
        public string Service { get; set; } = string.Empty;
        public string User { get; set; } = string.Empty;
        public string? Pass { get; set; } // null indica chave incorreta
    }
}
