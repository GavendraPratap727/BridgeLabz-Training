using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
     class ReplaceWord
    {
        static void Main()
        {
            Console.Write("Enter a sentence ");
            string s=Console.ReadLine();
            Console.Write("Enter word to replace: ");
            string ow=Console.ReadLine();
            Console.Write("Enter new word: ");
            string nw=Console.ReadLine();
            string res = s.Replace(ow, nw);
            Console.WriteLine("Modified Sentence: " + res);
        }
    }
}
