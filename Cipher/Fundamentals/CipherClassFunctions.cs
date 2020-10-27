using System;
using System.Collections.Generic;

namespace Cipher.Fundamentals
{
    public class CipherClassFunctions
    {

        // Initiate Characters Array
        public char[] chars = {
            'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h',
            'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p',
            'q', 'r', 's', 't', 'u', 'v', 'w', 'x',
            'y', 'z', '0', '1', '2', '3', '4', '5',
            '6', '7', '8', '9', 'A', 'B', 'C', 'D',
            'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L',
            'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T',
            'U', 'V', 'W', 'X', 'Y', 'Z', '!', '@',
            '#', '$', '%', '^', '&', '(', ')', '+',
            '-', '*', '/', '[', ']', '{', '}', '=',
            '<', '>', '?', '_', '"', '.', ',', ' '
        };      

        // Caesar cipher Encrypt Method
        public string Encrypt(string text, int offset)
        {
            char[] plain = text.ToCharArray();

            for (int i = 0; i < plain.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (j <= chars.Length - offset)
                    {
                        if (plain[i] == chars[j])
                        {
                            plain[i] = chars[j + offset];
                            break;
                        }
                    }
                    else if (plain[i] == chars[j])
                    {
                        plain[i] = chars[j - (chars.Length - offset + 1)];
                    }
                }
            }
            return new string(plain);
        }


        // Caesar cipher Decrypt Method
        public string Decrypt(string cip, int offset)
        {
            char[] cipher = cip.ToCharArray();

            for (int i = 0; i < cipher.Length; i++)
            {
                for (int j = 0; j < chars.Length; j++)
                {
                    if (j >= offset && cipher[i] == chars[j])
                    {
                        cipher[i] = chars[j - offset];
                        break;
                    }
                    if (cipher[i] == chars[j] && j < offset)
                    {
                        cipher[i] = chars[(chars.Length - offset + 1) + j];
                        break;
                    }
                }
            }
            return new string(cipher);
        }
    }
}