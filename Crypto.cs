using System;
using System.Text;

namespace Oodle
{
    class Crypto
    {
        public static string Encrypt(string StringToEncrypt, string PrivateKey)
        {
            string HardwareKey = "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";
            StringBuilder EncryptedString = new StringBuilder();
            int charCounter = 0;
            string encryptKey = "";
            for (int i = 0; i < (HardwareKey.Length * PrivateKey.Length); i++)
            {
                encryptKey = encryptKey + (char)((uint)PrivateKey[charCounter % PrivateKey.Length] ^ HardwareKey[charCounter % HardwareKey.Length]);
                charCounter++;
            }
            charCounter = 0;
            foreach (char character in StringToEncrypt)
            {
                EncryptedString.Append((char)((uint)character ^ (uint)encryptKey[charCounter % encryptKey.Length]));
                charCounter++;
            }
            return Convert.ToString(EncryptedString);
        }
    }
}
