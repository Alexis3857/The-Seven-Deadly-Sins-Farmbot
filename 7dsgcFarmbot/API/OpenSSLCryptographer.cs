using System.Security.Cryptography;
using System.Text;

namespace API
{
    public static class OpenSSLCryptographer  // Used to decrypt config files
    {
        private const int ContentOffset = 8;  // The content of the files to decrypt start with "Salted__" that has to be skipped
        public static string DecryptStringFromBytesAes(byte[] cipherText, byte[] key, byte[] iv)
        {
            using (Aes aes = Aes.Create())
            {
                aes.Mode = CipherMode.CBC;
                aes.KeySize = 256;
                aes.BlockSize = 128;
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream(cipherText))
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader streamReader = new StreamReader(cryptoStream))
                        {
                            return streamReader.ReadToEnd();
                        }
                    }
                }
            }
        }

        public static string Decrypt(string encrypted, string passphrase)
        {
            byte[] content = Convert.FromBase64String(encrypted);
            byte[] salt = new byte[8];
            Buffer.BlockCopy(content, ContentOffset, salt, 0, salt.Length);  // Get salt from content
            byte[] key;
            byte[] iv;
            DeriveKeyAndIV(passphrase, salt, out key, out iv);  // Compute the key and iv
            byte[] encryptedContent = new byte[content.Length - salt.Length - ContentOffset];
            Buffer.BlockCopy(content, ContentOffset + salt.Length, encryptedContent, 0, encryptedContent.Length);  // Get encrypted content
            return DecryptStringFromBytesAes(encryptedContent, key, iv);
        }

        private static void DeriveKeyAndIV(string passphrase, byte[] salt, out byte[] key, out byte[] iv)
        {
            List<byte> list = new List<byte>(48);
            byte[] bytes = Encoding.UTF8.GetBytes(passphrase);
            byte[] array = new byte[0];
            MD5 md = MD5.Create();
            bool flag = false;
            while (!flag)
            {
                byte[] array2 = new byte[array.Length + bytes.Length + salt.Length];
                Buffer.BlockCopy(array, 0, array2, 0, array.Length);
                Buffer.BlockCopy(bytes, 0, array2, array.Length, bytes.Length);
                Buffer.BlockCopy(salt, 0, array2, array.Length + bytes.Length, salt.Length);
                array = md.ComputeHash(array2);
                list.AddRange(array);
                if (list.Count >= 48)
                {
                    flag = true;
                }
            }
            key = new byte[32];
            iv = new byte[16];
            list.CopyTo(0, key, 0, 32);
            list.CopyTo(32, iv, 0, 16);
            md.Clear();
        }
    }
}
