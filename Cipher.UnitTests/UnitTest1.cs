using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cipher.Fundamentals;


namespace Cipher.UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Encrypt_By_2()
        {
            CipherClassFunctions main = new CipherClassFunctions();

            string plain_text = "ABC";
            string encrypted_text = "CDE";
            string testCipherText = main.Encrypt(plain_text, 2);

            Assert.AreEqual(testCipherText, encrypted_text);

            

        }

        [TestMethod]
        public void Decrypt_By_2()
        {
            CipherClassFunctions main = new CipherClassFunctions();

            string encrypted_text = "CDE";
            string decrypted_text = "ABC";
            string testPlainText = main.Decrypt(encrypted_text, 2);

            Assert.AreEqual(testPlainText, decrypted_text);
        }       
    }
}
