using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
    class LongestWord
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter  a sentence");
            string s= Console.ReadLine(); 
            string word="";
            string lon = "";
            for (int i = 0; i < s.Length; i++) {
                if (s[i] != ' ')
                {
                    word += s[i];
                }
                else {
                    if (word.Length > lon.Length) lon = word;
                    word = "";
                }
            }
            if(word.Length>lon.Length) lon = word;
            Console.WriteLine("longest word =" + lon);
            Console.WriteLine("its length =" + lon.Length);

        }
    }
}

