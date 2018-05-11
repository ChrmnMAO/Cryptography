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

            int key = -28;
            string  strCipher = "meet me later";
            string strPlain = "";
            
            foreach(char letter in strCipher.ToLower())
            {
                int posCipher = strAlphabet.IndexOf(letter);
                int posPlain = (posCipher - key) % 26;
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
