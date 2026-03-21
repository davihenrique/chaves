using System;
using System.Security.Cryptography;
using System.Text;

namespace Chaves.Service.Crypto
{
    public static class PasswordCrypto
    {
        private const string Magic = "CHAVES:";

        private static byte[] DeriveKey(string passphrase)
            => MD5.HashData(Encoding.UTF8.GetBytes(passphrase));

        public static string Encrypt(string plaintext, string passphrase)
        {
            var key = DeriveKey(passphrase);
            var input = Encoding.UTF8.GetBytes(Magic + plaintext);

            using var aes = Aes.Create();
            aes.Key = key;
            aes.IV = new byte[16];
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            using var encryptor = aes.CreateEncryptor();
            var encrypted = encryptor.TransformFinalBlock(input, 0, input.Length);
            return Convert.ToBase64String(encrypted);
        }

        public static string? TryDecrypt(string ciphertext, string passphrase)
        {
            try
            {
                var key = DeriveKey(passphrase);
                var input = Convert.FromBase64String(ciphertext);

                using var aes = Aes.Create();
                aes.Key = key;
                aes.IV = new byte[16];
                aes.Mode = CipherMode.CBC;
                aes.Padding = PaddingMode.PKCS7;

                using var decryptor = aes.CreateDecryptor();
                var decrypted = decryptor.TransformFinalBlock(input, 0, input.Length);
                var text = Encoding.UTF8.GetString(decrypted);

                return text.StartsWith(Magic) ? text[Magic.Length..] : null;
            }
            catch
            {
                return null;
            }
        }
    }
}
