using System.Security.Cryptography;

namespace API
{
    public static class AESEncrypter  // Used to encrypt some data sent to the auth server
    {
        public static string Encrypt(string value, string key, string iv)
        {
            string result;
            using (Aes aes = Aes.Create())
            {
                aes.Key = ConvertHexStringToByte(key.Substring(0, 32));
                aes.IV = ConvertHexStringToByte(iv.Substring(0, 32));
                byte[] inArray = EncryptStringToBytes_Aes(value, aes.Key, aes.IV);
                result = Convert.ToBase64String(inArray);
            }
            return result;
        }

        public static byte[] ConvertHexStringToByte(string convertString)
        {
            byte[] array = new byte[convertString.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToByte(convertString.Substring(i * 2, 2), 16);
            }
            return array;
        }

        public static byte[] EncryptStringToBytes_Aes(string plainText, byte[] key, byte[] iv)
        {
            if (plainText == null || plainText.Length <= 0)
            {
                throw new ArgumentNullException("plainText");
            }
            if (key == null || key.Length <= 0)
            {
                throw new ArgumentNullException("key");
            }
            if (iv == null || iv.Length <= 0)
            {
                throw new ArgumentNullException("iv");
            }
            byte[] result;
            using (Aes aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;
                ICryptoTransform transform = aes.CreateEncryptor(aes.Key, aes.IV);
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    using (CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write))
                    {
                        using (StreamWriter streamWriter = new StreamWriter(cryptoStream))
                        {
                            streamWriter.Write(plainText);
                        }
                        result = memoryStream.ToArray();
                    }
                }
            }
            return result;
        }
    }
}