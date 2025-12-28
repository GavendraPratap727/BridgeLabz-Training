using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bridge.StringExtra
{
     class MostFreq
    {
       public  static void Main(String[]args)
        {
            Console.Write("Enter a string: ");
            string s =Console.ReadLine();
            char max =s[0];
            int maxc = 0;

            for (int i=0; i<s.Length;i++)
            {
                int count = 0;
                for (int j=0;j<s.Length;j++)
                {
                    if (s[i]==s[j])
                        count++;
                }
                if (count > maxc)
                {
                    maxc = count;
                    max = s[i];
                }
            }
            Console.WriteLine("Most Frequent Character "+max);
        }
    }
}
