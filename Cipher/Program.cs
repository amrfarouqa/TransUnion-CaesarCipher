using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cipher.Fundamentals;

namespace Cipher
{
    class Program
    {
       
        static void Main(string[] args)
        {
            // Initiale Class
            CipherClassFunctions main = new CipherClassFunctions();
       
            // Manipulate Input Text Here
            string text = "ABC";

            // Manipulate Shift Key Here
            int offset = 2;

            string enc = main.Encrypt(text, offset);
            Console.WriteLine("Encrypted text: " + enc);

            string dec = main.Decrypt(enc, offset);
            Console.WriteLine("Decrypted text: " + dec);
        }      
    }
}