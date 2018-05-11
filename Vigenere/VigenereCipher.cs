using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vigenere
{
    class VigenereCipher
    {
        static void Main(string[] args)
        {
            string strAlphabet = "abcdefghijklmnopqrstuvwxyz";
            string key = "lemonissour";
            int keyLength = key.Length;

            string strToEncode = "i only regret that i have but one life to give for my country";
            string strPlain = "";

            for (int letter = 0; letter<= strToEncode.Length - 1; letter++)
            {
                if (strToEncode[letter].ToString() == " ")
                {
                    strPlain = strPlain + " ";
                    continue;
                }
                int posToEncode = strAlphabet.IndexOf(strToEncode[letter]);
                int posInKey = letter % keyLength;
                int posPlain = (posToEncode + strAlphabet.IndexOf(key[posInKey])) % 26;
                if (posPlain < 0)
                {
                    posPlain = posPlain + 26;
                }

                Console.WriteLine(strToEncode[letter] + "  " + key[posInKey] + "  " + strAlphabet[posPlain]);

                strPlain = strPlain + strAlphabet[posPlain];
            }

            Console.WriteLine(strPlain);
            Console.ReadLine();
        }
    }
}
