//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace bridge.StringExtra
//{
//    class VowelsAndCon
//    {
//        static void Main(String[] args)
//        {
//            Console.WriteLine("Enter a string");
//            string s = Console.ReadLine().ToLower(); //input a sting and convert it into the lowercase because we want to con.. only lowercaseletters
//            int vol = 0;
//            int con = 0;
//            for (int i = 0; i < s.Length; i++)
//            {
//                char c = s[i];
//                if (c >= 'a' && c <= 'z')
//                {
//                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u') vol++;
//                    else con++;

//                }
//            }
//            Console.WriteLine("Vowels " + vol);
//            Console.WriteLine("Consonants " + con);
//        }
//    }
//}
