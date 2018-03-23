using System;
using System.Collections.Generic;
using System.Linq;


namespace Caesar
{
    public class App
    {
        public static void Main(string[] args)
        { 
            string strAlphabet = "abcdefghijklmnopqrstuvwxyz";

            int key = 5;
            string  strCipher = "QNGWFWD";
            string strPlain = "";
            
            foreach(char letter in strCipher.ToLower())
            {
                int posCipher = strAlphabet.IndexOf(letter);
                int posPlain = posCipher - key;
                if (posPlain < 0)
                {
                    posPlain = posPlain + 26;                    
                }                
            
                strPlain = strPlain + strAlphabet[posPlain];
            }
            
            Console.WriteLine(strPlain);
        }
    }
}
